using System;
using DockerNet.Desktop.Pages.Dashboard;
using DockerNet.Desktop.Pages.Docker;
using DockerNet.Desktop.Pages.Settings;
using ReactiveUI;
using Splat;

namespace DockerNet.Desktop;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new();

    // view models 
    public ReactiveCommand<string, IRoutableViewModel> Navigate { get; }
    
    public MainWindowViewModel()
    {
        _registerSingletons();
        Navigate = ReactiveCommand.CreateFromObservable<string, IRoutableViewModel>(
            route => route switch
            {
                "dashboard" => Router?.Navigate.Execute(Locator.Current.GetService<DashboardPageModel>()),
                "docker" => Router?.Navigate.Execute(Locator.Current.GetService<DockerPageModel>()),
                "settings" => Router?.Navigate.Execute(Locator.Current.GetService<SettingsPageModel>()),
                _ => throw new InvalidOperationException()
            } ?? throw new InvalidOperationException() );
    }

    private void _registerSingletons()
    {
        // pages view models
        Locator.CurrentMutable.RegisterLazySingleton(() => new DashboardPageModel(this), typeof(DashboardPageModel));
        Locator.CurrentMutable.RegisterLazySingleton(() => new DockerPageModel(this), typeof(DockerPageModel));
        Locator.CurrentMutable.RegisterLazySingleton(() => new SettingsPageModel(this), typeof(SettingsPageModel));
    }

}