using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorServerSide.Breadcrumbs
{
    public class IndexBreadcrumb : RootBreadcrumb
    {
        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            builder.Link("Home", string.Empty);

            return Task.CompletedTask;
        }
    }
}
