#region Assembly Dalamud, Version=12.0.1.5, Culture=neutral, PublicKeyToken=null
// Dalamud.dll
#endregion

#nullable enable

using System;
using System.Collections.Generic;
using System.Numerics;
using ImGuiNET;

namespace Dalamud.Interface.Windowing {
    //
    // Summary:
    //     Base class you can use to implement an ImGui window for use with the built-in
    //     Dalamud.Interface.Windowing.WindowSystem.
    public abstract class Window {
        //
        // Summary:
        //     Initializes a new instance of the Dalamud.Interface.Windowing.Window class.
        //
        // Parameters:
        //   name:
        //     The name/ID of this window. If you have multiple windows with the same name,
        //     you will need to append a unique ID to it by specifying it after "###" behind
        //     the window title.
        //
        //   flags:
        //     The ImGuiNET.ImGuiWindowFlags of this window.
        //
        //   forceMainWindow:
        //     Whether this window should be limited to the main game window.
        protected Window(string name, ImGuiWindowFlags flags = ImGuiWindowFlags.None, bool forceMainWindow = false);

        //
        // Summary:
        //     Gets or sets the condition that defines when the position of this window is set.
        public ImGuiCond PositionCondition { get; set; }
        //
        // Summary:
        //     Gets or sets the size of the window. The size provided will be scaled by the
        //     global scale.
        public Vector2? Size { get; set; }
        //
        // Summary:
        //     Gets or sets the condition that defines when the size of this window is set.
        public ImGuiCond SizeCondition { get; set; }
        //
        // Summary:
        //     Gets or sets the size constraints of the window. The size constraints provided
        //     will be scaled by the global scale.
        public WindowSizeConstraints? SizeConstraints { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window is collapsed.
        public bool? Collapsed { get; set; }
        //
        // Summary:
        //     Gets or sets the condition that defines when the collapsed state of this window
        //     is set.
        public ImGuiCond CollapsedCondition { get; set; }
        //
        // Summary:
        //     Gets or sets the position of this window.
        public Vector2? Position { get; set; }
        //
        // Summary:
        //     Gets or sets the window flags.
        public ImGuiWindowFlags Flags { get; set; }
        //
        // Summary:
        //     Gets or sets this window's background alpha value.
        public float? BgAlpha { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this ImGui window should display a close
        //     button in the title bar.
        public bool ShowCloseButton { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window should offer to be pinned
        //     via the window's titlebar context menu.
        public bool AllowPinning { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window should offer to be made click-through
        //     via the window's titlebar context menu.
        public bool AllowClickthrough { get; set; }
        //
        // Summary:
        //     Gets or sets a list of available title bar buttons. If Dalamud.Interface.Windowing.Window.AllowPinning
        //     or Dalamud.Interface.Windowing.Window.AllowClickthrough are set to true, and
        //     this features is not disabled globally by the user, an internal title bar button
        //     to manage these is added when drawing, but it will not appear in this collection.
        //     If you wish to remove this button, set both of these values to false.
        public List<TitleBarButton> TitleBarButtons { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window will stay open.
        public bool IsOpen { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this ImGui window will be forced to stay
        //     inside the main game window.
        public bool ForceMainWindow { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window should not fade in and out,
        //     regardless of the users' preference.
        public bool DisableFadeInFadeOut { get; set; }
        //
        // Summary:
        //     Gets or sets a value representing the sound effect id to be played when the window
        //     is closed.
        public uint OnCloseSfxId { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window should not generate sound
        //     effects when opening and closing.
        public bool DisableWindowSounds { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this window is to be closed with a hotkey,
        //     like Escape, and keep game addons open in turn if it is closed.
        public bool RespectCloseHotkey { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the window is focused.
        public bool IsFocused { get; }
        //
        // Summary:
        //     Gets or sets the name of the window. If you have multiple windows with the same
        //     name, you will need to append an unique ID to it by specifying it after "###"
        //     behind the window title.
        public string WindowName { get; set; }
        //
        // Summary:
        //     Gets or sets the namespace of the window.
        public string? Namespace { get; set; }
        //
        // Summary:
        //     Gets or sets a value representing the sound effect id to be played when the window
        //     is opened.
        public uint OnOpenSfxId { get; set; }

        //
        // Summary:
        //     Bring this window to the front.
        public void BringToFront();
        //
        // Summary:
        //     Code to be executed every time the window renders.
        //
        // Remarks:
        //     In this method, implement your drawing code. You do NOT need to ImGui.Begin your
        //     window.
        public abstract void Draw();
        //
        // Summary:
        //     Additional conditions for the window to be drawn, regardless of its open-state.
        //
        //
        // Returns:
        //     True if the window should be drawn, false otherwise.
        //
        // Remarks:
        //     Not being drawn due to failing this condition will not change focus or trigger
        //     OnClose. This is checked before PreDraw, but after Update.
        public virtual bool DrawConditions();
        //
        // Summary:
        //     Code to be executed when the window is closed.
        public virtual void OnClose();
        //
        // Summary:
        //     Code to be executed when the window is opened.
        public virtual void OnOpen();
        //
        // Summary:
        //     Code to be executed when the window is safe to be disposed or removed from the
        //     window system. Doing so in Dalamud.Interface.Windowing.Window.OnClose may result
        //     in animations not playing correctly.
        public virtual void OnSafeToRemove();
        //
        // Summary:
        //     Code to be executed after the window is drawn.
        public virtual void PostDraw();
        //
        // Summary:
        //     Code to be executed before conditionals are applied and the window is drawn.
        public virtual void PreDraw();
        //
        // Summary:
        //     Code to always be executed before the open-state of the window is checked.
        public virtual void PreOpenCheck();
        //
        // Summary:
        //     Toggle window is open state.
        public void Toggle();
        //
        // Summary:
        //     Code to be executed every frame, even when the window is collapsed.
        public virtual void Update();

        //
        // Summary:
        //     Structure detailing the size constraints of a window.
        public struct WindowSizeConstraints {
            //
            // Summary:
            //     Initializes a new instance of the Dalamud.Interface.Windowing.Window.WindowSizeConstraints
            //     struct.
            public WindowSizeConstraints();

            //
            // Summary:
            //     Gets or sets the minimum size of the window.
            public Vector2 MinimumSize { readonly get; set; }
            //
            // Summary:
            //     Gets or sets the maximum size of the window.
            public Vector2 MaximumSize { get; set; }
        }

        //
        // Summary:
        //     Structure describing a title bar button.
        public class TitleBarButton {
            public TitleBarButton();

            //
            // Summary:
            //     Gets or sets the icon of the button.
            public FontAwesomeIcon Icon { get; set; }
            //
            // Summary:
            //     Gets or sets a vector by which the position of the icon within the button shall
            //     be offset. Automatically scaled by the global font scale for you.
            public Vector2 IconOffset { get; set; }
            //
            // Summary:
            //     Gets or sets an action that is called when a tooltip shall be drawn. May be null
            //     if no tooltip shall be drawn.
            public Action? ShowTooltip { get; set; }
            //
            // Summary:
            //     Gets or sets an action that is called when the button is clicked.
            public Action<ImGuiMouseButton> Click { get; set; }
            //
            // Summary:
            //     Gets or sets the priority the button shall be shown in. Lower = closer to ImGui
            //     default buttons.
            public int Priority { get; set; }
            //
            // Summary:
            //     Gets or sets a value indicating whether the button shall be clickable when the
            //     respective window is set to clickthrough.
            public bool AvailableClickthrough { get; set; }
        }
    }
}