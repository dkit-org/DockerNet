using System;
using System.Collections.ObjectModel;
using DockerNet.Desktop.Pages.Settings;
using ReactiveUI;
using Splat;

namespace DockerNet.Desktop.Pages.Docker;

public class DockerPageModel : ReactiveObject, IRoutableViewModel, IScreen
{
    public RoutingState Router { get; } = new();
    public string? UrlPathSegment { get; } = "/docker";
    public IScreen HostScreen { get; }
    
    public ObservableCollection<NavLink> NavLinks { get; } = new()
    {
        new ("images", "Images"),
        new ("containers", "Containers"),
    };

    public ReactiveCommand<string, IRoutableViewModel> Navigate;

    public DockerPageModel(IScreen screen)
    {
        HostScreen = screen;
        Navigate = ReactiveCommand.CreateFromObservable<string, IRoutableViewModel>(_navigateHandler);
        _registerSingletons();
    }
    
    public DockerPageModel(){}

    private IObservable<IRoutableViewModel> _navigateHandler(string route) => route switch
    {
        "images" => Router.Navigate.Execute(Locator.Current.GetService<ImagesViewModel>()),
        "containers" => Router.Navigate.Execute(Locator.Current.GetService<ContainersViewModel>()),
        _ => throw new ArgumentException("page not found")
    };

    private void _registerSingletons()
    {
        Locator.CurrentMutable.RegisterLazySingleton(() => new ImagesViewModel(this), typeof(ImagesViewModel));
        Locator.CurrentMutable.RegisterLazySingleton(() => new ContainersViewModel(this), typeof(ContainersViewModel));
    }
}