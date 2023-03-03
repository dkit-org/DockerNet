using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace DockerNet.Desktop.Pages.Docker;

public partial class ContainersView : ReactiveUserControl<ContainersViewModel>
{
    public ContainersView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
}