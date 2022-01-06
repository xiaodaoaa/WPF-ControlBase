﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace HeBianGu.General.WpfControlLib
{
    public static class ButtonKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Default");

        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Single");

        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Accent");

        public static ComponentResourceKey Transparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Transparent");
        public static ComponentResourceKey Link => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Link");
        public static ComponentResourceKey Circle => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Circle");
        public static ComponentResourceKey CircleTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Circle.Transparent");
        public static ComponentResourceKey AccentBackTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Transparent.AccentBack");
        public static ComponentResourceKey BorderBrushTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Transparent.BorderBrush");
        public static ComponentResourceKey MouseOver => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.MouseOver");
        public static ComponentResourceKey Close => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Close");
        public static ComponentResourceKey CloseFlag => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Close.Flag");
        public static ComponentResourceKey MinimizeWindow => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Window.Minimize");
        public static ComponentResourceKey MaximizeWindow => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Window.Maximize");
        public static ComponentResourceKey RestoreWindow => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Window.Restore");
        public static ComponentResourceKey HideWindow => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Window.Hide");
        public static ComponentResourceKey CloseWindow => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Window.Close");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Clear");

        public static ComponentResourceKey AddTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Add.Transparent");
        public static ComponentResourceKey AddTransparentBorder => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Add.Border");
        public static ComponentResourceKey Delete => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Delete");
        public static ComponentResourceKey Edit => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Edit");
        public static ComponentResourceKey Detial => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Detial");
        public static ComponentResourceKey Add => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Add");
        public static ComponentResourceKey Set => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Set");
        public static ComponentResourceKey CloseMouseOver => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Close.MouseOver");
        public static ComponentResourceKey CloseTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Close.Transparent");
        public static ComponentResourceKey Left => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Left");
        public static ComponentResourceKey Right => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Right");
        public static ComponentResourceKey Start => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Start");
        public static ComponentResourceKey Stop => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Stop");
        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Label");
        public static ComponentResourceKey VerticalToolBar => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Vertical.ToolBar");
        public static ComponentResourceKey SetTransparent => new ComponentResourceKey(typeof(ButtonKeys), "S.Button.Transparent.Set");

    }


    public static class BorderKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Default");
        public static ComponentResourceKey Circle => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Circle");

        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Single");

        public static ComponentResourceKey Card => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Card");

        public static ComponentResourceKey CardBorderThickness => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Card.BorderThickness");

        public static ComponentResourceKey CardBorderBrush => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Card.BorderBrush");
        public static ComponentResourceKey CardBackground => new ComponentResourceKey(typeof(BorderKeys), "S.Border.Card.Background");
    }

    public static class CheckBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(CheckBoxKeys), "S.CheckBox.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(CheckBoxKeys), "S.CheckBox.Single");

        public static ComponentResourceKey SingleLabel => new ComponentResourceKey(typeof(CheckBoxKeys), "S.CheckBox.Single.Label");

        public static ComponentResourceKey Box => new ComponentResourceKey(typeof(CheckBoxKeys), "S.CheckBox.Box");
    }


    public static class ComboBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Accent");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Clear");
        public static ComponentResourceKey Circle => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Circle");
        public static ComponentResourceKey LabelDefault => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Label.Default");
        public static ComponentResourceKey LabelClear => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.LabelClear");
        public static ComponentResourceKey LabelSingle => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Label.Single");
        public static ComponentResourceKey LabelAccent => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Label.Accent");
        public static ComponentResourceKey LabelClearSingle => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Label.SingleClear");
        public static ComponentResourceKey LabelCircle => new ComponentResourceKey(typeof(ComboBoxKeys), "S.ComboBox.Circle.Label");

    }

    public static class ComboBoxItemKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ComboBoxItemKeys), "S.ComboBoxItem.Default"); 
    }

    public static class DataGridKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(DataGridKeys), "S.DataGrid.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(DataGridKeys), "S.DataGrid.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(DataGridKeys), "S.DataGrid.Accent");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(DataGridKeys), "S.DataGrid.Clear");
        public static ComponentResourceKey VerticalDefault => new ComponentResourceKey(typeof(DataGridKeys), "S.DataGrid.Vertical.Default");
    }

    public static class DatePickerKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Accent");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Clear");
        public static ComponentResourceKey Circle => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Circle");

        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Label");
        public static ComponentResourceKey LabelClear => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.LabelClear");
        public static ComponentResourceKey LabelSingle => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Single.Label");
        public static ComponentResourceKey LabelClearSingle => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Single.LabelClear");
        public static ComponentResourceKey LabelCircle => new ComponentResourceKey(typeof(DatePickerKeys), "S.DatePicker.Circle.Label");
    }

    public static class CalendarKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(CalendarKeys), "S.Calendar.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(CalendarKeys), "S.Calendar.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(CalendarKeys), "S.Calendar.Accent"); 
    }

    public static class ExpanderKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ExpanderKeys), "S.Expander.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ExpanderKeys), "S.Expander.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ExpanderKeys), "S.Expander.Accent");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(ExpanderKeys), "S.Expander.Clear");
        public static ComponentResourceKey Transparent => new ComponentResourceKey(typeof(ExpanderKeys), "S.Expander.Transparent");
    }
    public static class GroupBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Accent");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Clear");
        public static ComponentResourceKey System => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.System");

        public static ComponentResourceKey Close => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Default.WithClose");
        public static ComponentResourceKey CloseSingle => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.Single.WithClose");
        public static ComponentResourceKey UnderLine => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.UnderLine");
        public static ComponentResourceKey ShowCode => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.ShowCode");
        public static ComponentResourceKey HeaderBottom => new ComponentResourceKey(typeof(GroupBoxKeys), "S.GroupBox.HeaderBottom");

        public static ComponentResourceKey ToolBar => new ComponentResourceKey(typeof(GroupBoxKeys), "S.Group.ToolBar");

    }

    public static class LabelKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(LabelKeys), "S.Label.Default");
        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(LabelKeys), "S.Label.Label");
        public static ComponentResourceKey IconRotate => new ComponentResourceKey(typeof(LabelKeys), "S.Label.Icon.Rotate");
        public static ComponentResourceKey Icon => new ComponentResourceKey(typeof(LabelKeys), "S.Label.Icon");
        public static ComponentResourceKey Flash => new ComponentResourceKey(typeof(LabelKeys), "S.Label.Flash");
    }

    public static class ListBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.Default");
        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.Label");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.Accent");

        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.Clear");

        public static ComponentResourceKey Fluid => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.FluidMoveBehavior");

        public static ComponentResourceKey CheckAll => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.All");

        public static ComponentResourceKey AllowDrag => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.AllowDrag");
        public static ComponentResourceKey AddCloseInner => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.InnerSource.AddClose");
        public static ComponentResourceKey CheckAllInner => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.InnerSource.CheckAll");


        public static ComponentResourceKey CheckBoxWrapPanel => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.WrapPanelSelecter.CheckBox");
        public static ComponentResourceKey WrapPanel => new ComponentResourceKey(typeof(ListBoxKeys), "S.ListBox.WrapPanelSelecter.Default");
    }

    public static class ListBoxItemKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Default");
        public static ComponentResourceKey LeftAccent => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.LeftAccent");
        public static ComponentResourceKey BottomAccent => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.BottomAccent");
        public static ComponentResourceKey WithBorder => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.WithBorder");
         
        public static ComponentResourceKey Border => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Border");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Clear");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Accent");
        public static ComponentResourceKey AccentBack => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.AccentBack");
        public static ComponentResourceKey Office => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.Office"); 
        public static ComponentResourceKey CheckAll => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.All");

        public static ComponentResourceKey CheckBox => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.CheckBox.Default"); 
        public static ComponentResourceKey CheckBoxBox => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.CheckBox.Box");
        public static ComponentResourceKey RadioButton => new ComponentResourceKey(typeof(ListBoxItemKeys), "S.ListBoxItem.RadioButton.Default");
    }


    public static class MenuKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(MenuKeys), "S.Menu.Default");
        public static ComponentResourceKey Handy => new ComponentResourceKey(typeof(MenuKeys), "S.Menu.Handy");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(MenuKeys), "S.Menu.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(MenuKeys), "S.Menu.Accent");
    }

    public static class MenuItemKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(MenuItemKeys), "S.MenuItem.Default");
        public static ComponentResourceKey Handy => new ComponentResourceKey(typeof(MenuItemKeys), "S.MenuItem.Handy");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(MenuItemKeys), "S.MenuItem.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(MenuItemKeys), "S.MenuItem.Accent");
        public static ComponentResourceKey Icon => new ComponentResourceKey(typeof(MenuItemKeys), "S.MenuItem.Icon");
    }

    public static class ContextMenuKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ContextMenuKeys), "S.ContextMenu.Default");
        public static ComponentResourceKey Handy => new ComponentResourceKey(typeof(ContextMenuKeys), "S.ContextMenu.Handy");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ContextMenuKeys), "S.ContextMenu.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ContextMenuKeys), "S.ContextMenu.Accent");
    }
    public static class PasswordBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Single");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Clear");
        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Label");

        public static ComponentResourceKey LabelClear => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.LabelClear");
        public static ComponentResourceKey LabelSingle => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Single.Label");
        public static ComponentResourceKey LabelClearSingle => new ComponentResourceKey(typeof(PasswordBoxKeys), "S.PasswordBox.Single.LabelClear");
    }

    public static class ProgressBarKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Single");
        public static ComponentResourceKey Buzy => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Buzy");
        public static ComponentResourceKey RunningPoint => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.RunningPoint");

        public static ComponentResourceKey RunningWaitting => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.RunningWaitting");
        public static ComponentResourceKey WaittingPercent => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.WaittingPercent");
        public static ComponentResourceKey CriclePercent => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.CriclePercent");

        public static ComponentResourceKey Handy => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Handy.Default");
        public static ComponentResourceKey HandySingle => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Handy.Single");

        public static ComponentResourceKey HandyAccent => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Handy.Accent");
        public static ComponentResourceKey HandyStripeBase => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Handy.Stripe.Base");
        public static ComponentResourceKey LabelHandy => new ComponentResourceKey(typeof(ProgressBarKeys), "S.ProgressBar.Handy.Label");
    }

    public static class RadioButtonKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(RadioButtonKeys), "S.RadioButton.Default");
        public static ComponentResourceKey Box => new ComponentResourceKey(typeof(RadioButtonKeys), "S.RadioButton.Box");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(RadioButtonKeys), "S.RadioButton.Single");
        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(RadioButtonKeys), "S.RadioButton.Clear");
    }

    public static class ScrollViewerKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ScrollViewerKeys), "S.ScrollViewer.Default");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ScrollViewerKeys), "S.ScrollViewer.Accent");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ScrollViewerKeys), "S.ScrollViewer.Single");
        public static ComponentResourceKey MouseGesture => new ComponentResourceKey(typeof(ScrollViewerKeys), "S.ScrollViewer.MouseGesture");
    }

    public static class SeparatorKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(SeparatorKeys), "S.Separator.Default"); 
        public static ComponentResourceKey Vertical => new ComponentResourceKey(typeof(SeparatorKeys), "S.Separator.Vertical"); 
    }

    public static class SliderKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Default");
        public static ComponentResourceKey Base => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Base");

        public static ComponentResourceKey Circle => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Circle");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Accent");
        public static ComponentResourceKey Value => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.WithValue");
        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Label");
        public static ComponentResourceKey ThumbDefault => new ComponentResourceKey(typeof(SliderKeys), "S.Slider.Thumb.Default");
 
    }

    public static class TabControlKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(TabControlKeys), "S.TabControl.Default"); 

        public static ComponentResourceKey Office => new ComponentResourceKey(typeof(TabControlKeys), "S.TabControl.Office");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(TabControlKeys), "S.TabControl.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(TabControlKeys), "S.TabControl.Accent"); 

    }

    public static class TabItemKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(TabItemKeys), "S.TabItem.Default");

        public static ComponentResourceKey Line => new ComponentResourceKey(typeof(TabItemKeys), "S.TabItem.Line.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(TabItemKeys), "S.TabItem.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(TabItemKeys), "S.TabItem.Accent");

        public static ComponentResourceKey Office => new ComponentResourceKey(typeof(TabItemKeys), "S.TabItem.Office");
    }

    public static class TextBlockKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.Default");

        public static ComponentResourceKey Icon => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.Icon");

        public static ComponentResourceKey Title => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.Title");
        public static ComponentResourceKey FontSize18 => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.FontSize.18");
        public static ComponentResourceKey FontSize16 => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.FontSize.16");
        public static ComponentResourceKey FontSize14 => new ComponentResourceKey(typeof(TextBlockKeys), "S.TextBlock.FontSize.14");
    }

    public static class HyperlinkKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(HyperlinkKeys), "S.Hyperlink.Default");

        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(HyperlinkKeys), "S.Hyperlink.Accent"); 
    }

    public static class TextBoxKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Default");

        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Single");

        public static ComponentResourceKey Label => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Label");

        public static ComponentResourceKey LabelSingle => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Single.Label");

        public static ComponentResourceKey Clear => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Clear"); 
        public static ComponentResourceKey OpenFile => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.OpenFile");

        public static ComponentResourceKey OpenFolder => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.OpenFolder");
        public static ComponentResourceKey SaveFile => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.SaveFile");

        public static ComponentResourceKey Inner => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Inner");

        public static ComponentResourceKey Search => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Search");
        public static ComponentResourceKey ClearSingle => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Single.Clear");

        public static ComponentResourceKey LabelClear => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.LabelClear");
        public static ComponentResourceKey LabelClearSingle => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Single.LabelClear");

        public static ComponentResourceKey LabelClearUnderLine => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.UnderLine.LabelClear");
        public static ComponentResourceKey ClearUnderLine => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.UnderLine.Clear");

        public static ComponentResourceKey LabelClearAlarmUnderLine => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.UnderLine.LabelClearAlarm");
        public static ComponentResourceKey ClearInner => new ComponentResourceKey(typeof(TextBoxKeys), "S.TextBox.Inner.Clear"); 
    }

    public static class ToggleButtonKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.Default"); 
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.Accent" );
        public static ComponentResourceKey BrushFIconChecked => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.BrushFIconChecked");
        public static ComponentResourceKey BrushFIconCheckedRightToLeft => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.BrushFIconChecked.RightToLeft");
        public static ComponentResourceKey DoubleFIconChecked => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.DoubleFIconChecked");
        public static ComponentResourceKey DoubleFIconCheckedSingle => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.DoubleFIconChecked.Single");
        public static ComponentResourceKey FIconSingle => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.FIconSingle");
        public static ComponentResourceKey Rotate90 => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.Rotate.90");
        public static ComponentResourceKey Tree => new ComponentResourceKey(typeof(ToggleButtonKeys), "S.ToggleButton.Tree");

    }

    public static class ToolTipkKeys
    {
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(ToolTipkKeys), "S.ToolTip.Default");
        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(ToolTipkKeys), "S.ToolTip.Single");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(ToolTipkKeys), "S.ToolTip.Accent");
    }

    public static class TreeViewKeys
    {
        public static ComponentResourceKey Material => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Material");
        public static ComponentResourceKey Accent => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Accent");
        public static ComponentResourceKey Default => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Default");

        public static ComponentResourceKey Single => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Single");
        public static ComponentResourceKey HandyAccent => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Handy.Accent");

        public static ComponentResourceKey HandyDefault => new ComponentResourceKey(typeof(TreeViewKeys), "S.TreeView.Handy.Default"); 
    }
}
