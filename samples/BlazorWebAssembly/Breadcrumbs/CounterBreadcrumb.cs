using Juniperr.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class CounterBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(BreadcrumbBuilder builder)
        {
            builder.SetUrl("counter");
            builder.SetTitle("Counter");

            return Task.CompletedTask;
        }
    }
}
