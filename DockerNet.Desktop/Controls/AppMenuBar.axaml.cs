using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DockerNet.Desktop.Controls;

public partial class AppMenuBar : UserControl
{
    public AppMenuBar()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}