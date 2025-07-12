#region Assembly Dalamud, Version=12.0.1.5, Culture=neutral, PublicKeyToken=null
// Dalamud.dll
#endregion

#nullable enable

using System;
using System.Numerics;
using ImGuiNET;
using ImPlotNET;

namespace Dalamud.Interface.Utility.Raii {
    public static class ImRaii {
        public static IEndObject AlignedPlots(string group_id, bool vertical = true);
        public static IEndObject Child(string strId);
        public static IEndObject Child(string strId, Vector2 size);
        public static IEndObject Child(string strId, Vector2 size, bool border);
        public static IEndObject Child(string strId, Vector2 size, bool border, ImGuiWindowFlags flags);
        public static IEndObject Combo(string label, string previewValue, ImGuiComboFlags flags);
        public static IEndObject Combo(string label, string previewValue);
        public static IEndObject ContextPopup(string id, ImGuiPopupFlags flags);
        public static IEndObject ContextPopup(string id);
        public static IEndObject ContextPopupItem(string id, ImGuiPopupFlags flags);
        public static IEndObject ContextPopupItem(string id);
        public static Color DefaultColors();
        public static Font DefaultFont();
        public static PlotColor DefaultPlotColors();
        public static PlotStyle DefaultPlotStyle();
        public static Style DefaultStyle();
        public static IEndObject Disabled();
        public static IEndObject Disabled(bool disabled);
        public static IEndObject DragDropSource(ImGuiDragDropFlags flags);
        public static IEndObject DragDropSource();
        public static IEndObject DragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags = ImGuiDragDropFlags.None);
        public static IEndObject DragDropSourceItem(string label_id, ImGuiDragDropFlags flags = ImGuiDragDropFlags.None);
        public static IEndObject DragDropSourcePlot(ImGuiDragDropFlags flags = ImGuiDragDropFlags.None);
        public static IEndObject DragDropTarget();
        public static IEndObject DragDropTargetAxis(ImAxis axis);
        public static IEndObject DragDropTargetLegend();
        public static IEndObject DragDropTargetPlot();
        public static IEndObject Enabled();
        public static IEndObject Group();
        //
        // Summary:
        //     Pushes the item width for the next widget and returns an IDisposable that pops
        //     the width when done.
        //
        // Parameters:
        //   width:
        //     The width to set the next widget to.
        //
        // Returns:
        //     An System.IDisposable for use in a using statement.
        public static IEndObject ItemWidth(float width);
        public static IEndObject LegendPopup(string label_id, ImGuiMouseButton mouse_button = ImGuiMouseButton.Right);
        public static IEndObject ListBox(string label);
        public static IEndObject ListBox(string label, Vector2 size);
        public static IEndObject MainMenuBar();
        public static IEndObject Menu(string label);
        public static IEndObject MenuBar();
        public static IEndObject Plot(string title_id, Vector2 size, ImPlotFlags flags);
        public static IEndObject Popup(string id, ImGuiWindowFlags flags);
        public static IEndObject Popup(string id);
        public static IEndObject PopupModal(string id);
        public static IEndObject PopupModal(string id, ref bool open, ImGuiWindowFlags flags);
        public static IEndObject PopupModal(string id, ref bool open);
        public static Color PushColor(ImGuiCol idx, uint color, bool condition = true);
        public static Color PushColor(ImGuiCol idx, Vector4 color, bool condition = true);
        public static PlotColor PushColor(ImPlotCol idx, Vector4 color, bool condition = true);
        public static PlotColor PushColor(ImPlotCol idx, uint color, bool condition = true);
        public static Font PushFont(ImFontPtr font, bool condition = true);
        public static Id PushId(string id, bool enabled = true);
        public static Id PushId(int id, bool enabled = true);
        public static Id PushId(nint id, bool enabled = true);
        public static Indent PushIndent(float f, bool scaled = true, bool condition = true);
        public static Indent PushIndent(int i = 1, bool condition = true);
        public static Style PushStyle(ImGuiStyleVar idx, Vector2 value, bool condition = true);
        public static PlotStyle PushStyle(ImPlotStyleVar idx, float value, bool condition = true);
        public static PlotStyle PushStyle(ImPlotStyleVar idx, Vector2 value, bool condition = true);
        public static PlotStyle PushStyle(ImPlotStyleVar idx, int value, bool condition = true);
        public static Style PushStyle(ImGuiStyleVar idx, float value, bool condition = true);
        public static IEndObject Subplots(string title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags = ImPlotSubplotFlags.None);
        public static IEndObject Subplots(string title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float row_ratios, ref float col_ratios);
        public static IEndObject TabBar(string label);
        public static IEndObject TabBar(string label, ImGuiTabBarFlags flags);
        public static IEndObject TabItem(string label, ref bool open, ImGuiTabItemFlags flags);
        public static IEndObject TabItem(string label, ref bool open);
        public static IEndObject TabItem(string label, ImGuiTabItemFlags flags);
        public static IEndObject TabItem(byte* label, ImGuiTabItemFlags flags);
        public static IEndObject TabItem(string label);
        public static IEndObject Table(string table, int numColumns);
        public static IEndObject Table(string table, int numColumns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth);
        public static IEndObject Table(string table, int numColumns, ImGuiTableFlags flags, Vector2 outerSize);
        public static IEndObject Table(string table, int numColumns, ImGuiTableFlags flags);
        //
        // Summary:
        //     Pushes the item wrapping width for the next string written and returns an IDisposable
        //     that pops the wrap width when done.
        //
        // Parameters:
        //   pos:
        //     The wrap width to set the next text written to.
        //
        // Returns:
        //     An System.IDisposable for use in a using statement.
        public static IEndObject TextWrapPos(float pos);
        public static IEndObject Tooltip();
        public static IEndObject TreeNode(string label);
        public static IEndObject TreeNode(string label, ImGuiTreeNodeFlags flags);

        public interface IEndObject : IDisposable {
            public static readonly IEndObject Empty;

            bool Success { get; }

            static bool operator !(IEndObject i);
            static bool operator &(IEndObject i, bool value);
            static bool operator |(IEndObject i, bool value);
            static bool operator true(IEndObject i);
            static bool operator false(IEndObject i);
        }

        public sealed class PlotColor : IDisposable {
            public PlotColor();

            public void Dispose();
            public void Pop(int num = 1);
            public PlotColor Push(ImPlotCol idx, uint color, bool condition = true);
            public PlotColor Push(ImPlotCol idx, Vector4 color, bool condition = true);
        }
        public sealed class Color : IDisposable {
            public Color();

            public void Dispose();
            public void Pop(int num = 1);
            public Color Push(ImGuiCol idx, uint color, bool condition = true);
            public Color Push(ImGuiCol idx, Vector4 color, bool condition = true);
        }
        public sealed class Font : IDisposable {
            public Font();

            public void Dispose();
            public void Pop(int num = 1);
            public Font Push(ImFontPtr font, bool condition = true);
        }
        public sealed class Id : IDisposable {
            public Id();

            public void Dispose();
            public void Pop(int num = 1);
            public Id Push(string id, bool condition = true);
            public Id Push(int id, bool condition = true);
            public Id Push(nint id, bool condition = true);
        }
        public sealed class Indent : IDisposable {
            public Indent();

            public float Indentation { get; }

            public void Dispose();
            public void Pop(float indent, bool scaled = true);
            public void Pop(int i);
            public Indent Push(float indent, bool scaled = true, bool condition = true);
            public Indent Push(int i = 1, bool condition = true);
        }
        public sealed class PlotStyle : IDisposable {
            public PlotStyle();

            public static Vector2 GetStyle(ImPlotStyleVar idx);
            public void Dispose();
            public void Pop(int num = 1);
            public PlotStyle Push(ImPlotStyleVar idx, int value, bool condition = true);
            public PlotStyle Push(ImPlotStyleVar idx, float value, bool condition = true);
            public PlotStyle Push(ImPlotStyleVar idx, Vector2 value, bool condition = true);
        }
        public sealed class Style : IDisposable {
            public Style();

            public static Vector2 GetStyle(ImGuiStyleVar idx);
            public void Dispose();
            public void Pop(int num = 1);
            public Style Push(ImGuiStyleVar idx, float value, bool condition = true);
            public Style Push(ImGuiStyleVar idx, Vector2 value, bool condition = true);
        }
    }
}