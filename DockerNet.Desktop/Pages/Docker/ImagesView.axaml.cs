using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace DockerNet.Desktop.Pages.Docker;

public partial class ImagesView : ReactiveUserControl<ImagesViewModel>
{
    public ImagesView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}