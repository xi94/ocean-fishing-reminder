using System;
using System.Numerics;

using Dalamud.Game.Command;
using Dalamud.Configuration;

using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using Dalamud.Interface.Windowing;
using Dalamud.Interface.Utility.Raii;

using ImGuiNET;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace OceanFishingReminder;

// @Todo: add an option to enable/disable the notification during instance
// @Todo: add an option to see the time left until the ocean fishing queue starts

[Serializable]
public class Configuration : IPluginConfiguration {
    public int Version { get; set; } = 2;

    public bool ShouldRemindUser { get; set; } = false;
    public int ReminderThreshold { get; set; } = 5; // minutes left until the ocean fishing queue starts

    public void Save() => OceanFishingReminder.PluginInterface.SavePluginConfig(this);
}

public class MainWindow : Window, IDisposable {
    private OceanFishingReminder Plugin;
    private Configuration Config;

    static private readonly ImGuiWindowFlags WindowFlags = ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollWithMouse;
    
    public MainWindow(OceanFishingReminder plugin) : base("Ocean Fishing Reminder", WindowFlags) {
        Plugin = plugin;
        Config = Plugin.Config;
        
        SizeConstraints = new WindowSizeConstraints {
            MinimumSize = new Vector2(280, 150),
            MaximumSize = new Vector2(280, 150)
        };
    }

    public void Dispose() { }

    public override void Draw() {
        using (var child = ImRaii.Child("SomeChildWithAScrollbar", Vector2.Zero, true)) {
            if (!child.Success) return;

            // yeah we love it
            var remindUser = Config.ShouldRemindUser;
            if (ImGui.Checkbox("Reminder", ref remindUser)) {
                Config.ShouldRemindUser = remindUser;
                Config.Save();
            }

            // no need to continue here as the rest will be a submenu of sorts
            if (!remindUser) return;

            float xPad = 26;

            ImGui.SetCursorPosX(ImGui.GetCursorPosX() + xPad);
            ImGui.Text("Time Before Reminder (Min)");

            ImGui.SetNextItemWidth(178);
            ImGui.SetCursorPosX(ImGui.GetCursorPosX() + xPad);

            int timeBeforeReminder = Config.ReminderThreshold;
            if (ImGui.SliderInt("##time remainder slider", ref timeBeforeReminder, 1, 60)) {
                timeBeforeReminder = Math.Clamp(timeBeforeReminder, 1, 60); // ensure Ctrl + M1 values dont go above the limit
                Config.ReminderThreshold = timeBeforeReminder;
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

    public readonly WindowSystem WindowSystem = new();
    private MainWindow MainWindow { get; init; }

    private bool HasNotified = false;
    private DateTime NextCheckTime = DateTime.MinValue;

    public OceanFishingReminder() {
        Config = PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
        
        MainWindow = new MainWindow(this);
        WindowSystem.AddWindow(MainWindow);

        CommandManager.AddHandler(CommandName, new CommandInfo(OnCommand) { HelpMessage = "Open Ocean Fishing Reminder configuration" });

        PluginInterface.UiBuilder.Draw += DrawUI;
        PluginInterface.UiBuilder.OpenMainUi += ToggleMainUI;
        PluginInterface.UiBuilder.OpenConfigUi += ToggleMainUI;

        Framework.Update += OnFrameworkUpdate;
    }

    private unsafe void OnFrameworkUpdate(IFramework framework) {
        if (!Config.ShouldRemindUser) return;
    
        var now = DateTime.Now;
        if (now < NextCheckTime) return;
    
        CheckOceanFishingTimer();
        NextCheckTime = now.AddSeconds(1);
    }

    private void CheckOceanFishingTimer() {
        var ts = FFXIVClientStructs.FFXIV.Client.System.Framework.Framework.GetServerTime();
        var time = DateTimeOffset.FromUnixTimeSeconds(ts).DateTime;

        var nextFishingHour = time.Hour % 2 == 0 ? time.Hour : time.Hour + 1;
        if (nextFishingHour >= 24) nextFishingHour = 0;

        var nextFishingTime = new DateTime(time.Year, time.Month, time.Day, nextFishingHour, 0, 0);
        if (nextFishingTime <= time) nextFishingTime = nextFishingTime.AddHours(2);

        var timeUntilFishing = nextFishingTime - time;
        var minutesLeft = (int)Math.Ceiling(timeUntilFishing.TotalMinutes);
    
        if (minutesLeft <= 0 || minutesLeft > Config.ReminderThreshold) {
            HasNotified = false;
            return;
        }

        if (!HasNotified) {
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

    private void DrawUI() => WindowSystem.Draw();
    private void OnCommand(string command, string args) => ToggleMainUI();
    public void ToggleMainUI() => MainWindow.Toggle();
}