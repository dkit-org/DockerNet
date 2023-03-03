using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using ReactiveUI;
using Splat;

namespace DockerNet.Desktop.Pages.Settings;

public class SettingsPageModel : ReactiveObject, IRoutableViewModel, IScreen
{
    public RoutingState Router { get; } = new();
    public string? UrlPathSegment => "/settings";
    public ObservableCollection<NavLink> NavLinks { get; } = new()
    {
        new ("appearance", "Appearance"),
        new ("servers", "Servers"),
    };
    
    public IScreen HostScreen { get; }
    public ReactiveCommand<NavLink, IRoutableViewModel> Navigate { get; }

    public SettingsPageModel(IScreen screen)
    {
        HostScreen = screen;
        _registerSingletons();
        
        Navigate = ReactiveCommand.CreateFromObservable<NavLink, IRoutableViewModel>(_navigateCommandHandler);
    }

    public SettingsPageModel()
    {
    }

    private IObservable<IRoutableViewModel> _navigateCommandHandler(NavLink route) => route.Key switch
    {
        "appearance" => Router.Navigate.Execute(Locator.Current.GetService<AppearanceViewModel>()),
        "servers" => Router.Navigate.Execute(Locator.Current.GetService<ServersViewModel>()),
        _ => throw new InvalidOperationException()
    } ?? throw new InvalidOperationException();


    private void _registerSingletons()
    {
        Locator.CurrentMutable.RegisterLazySingleton(() => new AppearanceViewModel(this), typeof(AppearanceViewModel));
        Locator.CurrentMutable.RegisterLazySingleton(() => new ServersViewModel(this), typeof(ServersViewModel));
    }
}