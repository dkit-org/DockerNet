using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Settings;

public partial class SettingsPage : ReactiveUserControl<SettingsPageModel>
{
    public SettingsPage()
    {
        this.WhenActivated(disposable => { });
        AvaloniaXamlLoader.Load(this);
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        ViewModel.Navigate.Execute((NavLink)e.AddedItems[0]);
    }
}