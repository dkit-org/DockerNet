using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace DockerNet.Desktop.Pages.Settings;

public partial class AppearanceView : ReactiveUserControl<AppearanceViewModel>
{
    public AppearanceView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}