using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace DockerNet.Desktop.Pages.Settings;

public partial class ServersView : ReactiveUserControl<ServersViewModel>
{
    public ServersView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}