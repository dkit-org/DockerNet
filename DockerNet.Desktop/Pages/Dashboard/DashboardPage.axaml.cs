using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Dashboard;

public partial class DashboardPage : ReactiveUserControl<DashboardPageModel>
{
    public DashboardPage()
    {
        this.WhenActivated(disposable => { });
        AvaloniaXamlLoader.Load(this);
    }
}