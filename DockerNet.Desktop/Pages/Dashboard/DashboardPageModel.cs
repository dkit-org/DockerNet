using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using ReactiveUI;

namespace DockerNet.Desktop.Pages.Dashboard;

public class DashboardPageModel : ReactiveObject, IRoutableViewModel, IScreen
{
    public string? UrlPathSegment => "/dashboard";
    public RoutingState Router { get; } = new();
    public IScreen HostScreen { get;}
    public ISeries[] Series { get; }
    public DashboardPageModel(IScreen screen)
    {
        HostScreen = screen;
        Series = new ISeries[]
        {
            new ColumnSeries<int>()
            {
                Values = new[]{1,2,3,4},
                Name = "test"
            }
        };
    }
    
}