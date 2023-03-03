using System;
using DockerNet.Desktop.Pages.Dashboard;
using DockerNet.Desktop.Pages.Docker;
using DockerNet.Desktop.Pages.Settings;
using ReactiveUI;

namespace DockerNet.Desktop;

public class AppViewLocator : IViewLocator
{
    public IViewFor? ResolveView<T>(T viewModel, string? contract = null) => viewModel switch
    {
        DashboardPageModel context => new DashboardPage { DataContext = context },
        
        SettingsPageModel context => new SettingsPage { DataContext = context },
        AppearanceViewModel context => new AppearanceView{ DataContext = context},
        ServersViewModel context => new ServersView{ DataContext = context},
        
        
        DockerPageModel context => new DockerPage { DataContext = context },
        ImagesViewModel context => new ImagesView { DataContext = context},
        ContainersViewModel context => new ContainersView { DataContext = context},
        
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}