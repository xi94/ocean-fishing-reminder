using System;
using System.Linq;
using System.Numerics;
using Dalamud.Configuration;
using Dalamud.Game.Command;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.Game.Text.SeStringHandling.Payloads;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game.Event;
using FFXIVClientStructs.FFXIV.Client.UI;
using ImGuiNET;
using Lumina.Excel.Sheets;

namespace OceanFishingReminder;

[Serializable]
public class Configuration : IPluginConfiguration {
    public int Version { get; set; } = 1;

    public bool RemindUser { get; set; } = false;
    public int TimeBeforeReminder { get; set; } = 5;

    public void Save() => OceanFishingReminder.PluginInterface.SavePluginConfig(this);
}

public class MainWindow : Window, IDisposable {
    private OceanFishingReminder Plugin;
    private Configuration Config;

    public MainWindow(OceanFishingReminder plugin)
        : base("Ocean Fishing Reminder##hamstercute", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse) {
        SizeConstraints = new WindowSizeConstraints {
            MinimumSize = new Vector2(300, 100),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };

        Plugin = plugin;
        Config = Plugin.Config;
    }

    public void Dispose() { }

    public override void Draw() {
        using (var child = ImRaii.Child("SomeChildWithAScrollbar", Vector2.Zero, true)) {
            if (!child.Success) return;

            // yeah we love it
            var remindUser = Config.RemindUser;
            if (ImGui.Checkbox("Reminder", ref remindUser)) {
                Config.RemindUser = remindUser;
                Config.Save();
            }

            // no need to continue here as the rest will be a submenu of sorts
            if (!remindUser) return;

            float xPad = 26;

            ImGui.SetCursorPosX(ImGui.GetCursorPosX() + xPad);
            ImGui.Text("Time Before Reminder (Min)");

            ImGui.SetNextItemWidth(178);
            ImGui.SetCursorPosX(ImGui.GetCursorPosX() + xPad);

            int timeBeforeReminder = Config.TimeBeforeReminder;
            if (ImGui.SliderInt("##time remainder slider", ref timeBeforeReminder, 1, 60)) {
                timeBeforeReminder = Math.Clamp(timeBeforeReminder, 1, 60); // ensure Ctrl + M1 values dont go above the limit
                Config.TimeBeforeReminder = timeBeforeReminder;
                Config.Save();
            }
        }
    }
}

public class OceanFishingReminder : IDalamudPlugin {
    [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] internal static ICommandManager CommandManager { get; set; } = null!;
    [PluginService] internal static IFramework Framework { get; private set; } = null!;

    private const string CommandName = "/fishreminder";
    public Configuration Config { get; init; }

    public readonly WindowSystem WindowSystem = new("Hamster Differential");
    private MainWindow MainWindow { get; init; }

    private bool HasNotified = false;
    private long LastServerTime = 0;

    public OceanFishingReminder() {
        Config = PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
        MainWindow = new MainWindow(this);

        PluginInterface.UiBuilder.Draw += DrawUI;
        PluginInterface.UiBuilder.OpenMainUi += ToggleMainUI;
        PluginInterface.UiBuilder.OpenConfigUi += ToggleMainUI;

        Framework.Update += OnFrameworkUpdate;
    }

    private unsafe void OnFrameworkUpdate(IFramework framework) {
        if (!Config.RemindUser) return;

        var serverTime = FFXIVClientStructs.FFXIV.Client.System.Framework.Framework.GetServerTime();
        if (serverTime != LastServerTime) {
            CheckOceanFishingTimer();
            LastServerTime = serverTime;
        }
    }

    private void CheckOceanFishingTimer() {
        var ts = FFXIVClientStructs.FFXIV.Client.System.Framework.Framework.GetServerTime();
        var time = DateTimeOffset.FromUnixTimeSeconds(ts).DateTime;

        var nextFishingHour = time.Hour % 2 == 0 ? time.Hour : time.Hour + 1;
        if (nextFishingHour >= 24) nextFishingHour = 0;

        var nextFishingTime = new DateTime(time.Year, time.Month, time.Day, nextFishingHour, 0, 0);
        if (nextFishingTime <= time) nextFishingTime = nextFishingTime.AddHours(2);

        var timeUntilFishing = nextFishingTime - time;
        if (timeUntilFishing.TotalMinutes <= 0 || timeUntilFishing.TotalMinutes > 60) {
            HasNotified = false;
            return;
        }

        var minutesLeft = (int)Math.Ceiling(timeUntilFishing.TotalMinutes);
        if (minutesLeft <= Config.TimeBeforeReminder && minutesLeft > 0 && !HasNotified) {
            HasNotified = true;
            ShowNotification($"Ocean Fishing starts in {minutesLeft} minute{(minutesLeft == 1 ? "" : "s")}!");
        }
    }

    private unsafe void ShowNotification(string text) {
        var timer = 10 * 5; // 5 seconds
        RaptureAtkModule.Instance()->ShowTextGimmickHint(text, RaptureAtkModule.TextGimmickHintStyle.Info, timer);
    }

    public void Dispose() {
        WindowSystem.RemoveAllWindows();
        MainWindow.Dispose();
        CommandManager.RemoveHandler(CommandName);
    }

    private void DrawUI() => MainWindow.Draw();
    private void OnCommand(string command, string args) => ToggleMainUI();
    public void ToggleMainUI() => MainWindow.Toggle();
}
