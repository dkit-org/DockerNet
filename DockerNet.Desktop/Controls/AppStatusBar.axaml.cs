using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DockerNet.Desktop.Controls;

public partial class AppStatusBar : UserControl
{
    public AppStatusBar()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}