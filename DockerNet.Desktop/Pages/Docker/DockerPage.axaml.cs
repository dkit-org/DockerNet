using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using DockerNet.Desktop.Pages.Settings;

namespace DockerNet.Desktop.Pages.Docker;

public partial class DockerPage : ReactiveUserControl<DockerPageModel>
{
    public DockerPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var page = e.AddedItems[0] as NavLink;
        ViewModel.Navigate.Execute(page.Key);
    }
}