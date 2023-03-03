using Avalonia;
using Avalonia.ReactiveUI;

namespace DockerNet.Desktop;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
}