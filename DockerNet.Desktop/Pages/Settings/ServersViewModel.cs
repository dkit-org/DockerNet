using System.Collections.ObjectModel;
using System.Reactive.Linq;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Settings;

public class ServersViewModel: ReactiveObject, IRoutableViewModel
{
    
    public string? UrlPathSegment { get; } = "/servers";
    public IScreen HostScreen { get; }

    // public ObservableCollection<Server> Servers => new ObservableCollection<Server>(_serverService.GetServers());

    public ServersViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}