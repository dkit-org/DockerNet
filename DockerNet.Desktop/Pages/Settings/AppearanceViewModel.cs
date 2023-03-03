using ReactiveUI;

namespace DockerNet.Desktop.Pages.Settings;

public class AppearanceViewModel: ReactiveObject, IRoutableViewModel
{
    public string? UrlPathSegment { get; } = "/appearance";
    public IScreen HostScreen { get; }

    public AppearanceViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}