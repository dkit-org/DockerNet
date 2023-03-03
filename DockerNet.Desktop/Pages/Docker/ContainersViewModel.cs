using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using Docker.DotNet;
using Docker.DotNet.Models;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Docker;

public class ContainersViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel 
{
    public string? UrlPathSegment => "/containers";
    public IScreen HostScreen { get; }
    public ViewModelActivator Activator { get; }
    public ObservableCollection<ContainerListResponse> Containers { get; set; }
    private DockerClient _dockerClient; 

    public ContainersViewModel(IScreen screen)
    {
        HostScreen = screen;
        Activator = new ViewModelActivator();
        this.WhenActivated( async (CompositeDisposable disposables) =>
        {
            /* handle activation */
             _dockerClient = new DockerClientConfiguration().CreateClient();
             var containers =
                await _dockerClient.Containers.ListContainersAsync(new ContainersListParameters() { Limit = 10 });
             Containers = new ObservableCollection<ContainerListResponse>(containers);
             
            Disposable
                .Create(() => { /* handle deactivation */ })
                .DisposeWith(disposables);
        });
    }

}