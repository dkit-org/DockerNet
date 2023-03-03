using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DockerNet.Desktop.Controls;

public partial class SearchEveryWhere : UserControl
{
    public SearchEveryWhere()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}