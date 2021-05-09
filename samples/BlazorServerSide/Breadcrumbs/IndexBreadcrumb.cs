using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorServerSide.Breadcrumbs
{
    public class IndexBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(BreadcrumbBuilder builder)
        {
            builder.SetUrl(string.Empty);
            builder.SetTitle("Home");

            return Task.CompletedTask;
        }
    }
}
