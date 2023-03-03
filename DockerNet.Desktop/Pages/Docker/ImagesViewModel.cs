using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using Docker.DotNet;
using Docker.DotNet.Models;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Docker;

public class ImagesViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel
{
    public ViewModelActivator Activator { get; }
    public string? UrlPathSegment => "/containers";
    public IScreen HostScreen { get; }
    private DockerClient _dockerClient; 
    public ObservableCollection<ImagesListResponse> Images { get; set; }

    public ImagesViewModel(IScreen screen)
    {
        HostScreen = screen;    
        
        Activator = new ViewModelActivator();
        this.WhenActivated( async (CompositeDisposable disposables) =>
        {
            /* handle activation */
            _dockerClient = new DockerClientConfiguration().CreateClient();
            var images =
                await _dockerClient.Images.ListImagesAsync(new ImagesListParameters());
            Images = new ObservableCollection<ImagesListResponse>(images);
             
            Disposable
                .Create(() => { /* handle deactivation */ })
                .DisposeWith(disposables);
        });
    }
}