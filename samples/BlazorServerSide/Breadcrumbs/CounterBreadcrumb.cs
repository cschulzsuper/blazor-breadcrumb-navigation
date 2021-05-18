using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorServerSide.Breadcrumbs
{
    public class CounterBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            builder.Link("Counter", "counter");

            return Task.CompletedTask;
        }
    }
}
