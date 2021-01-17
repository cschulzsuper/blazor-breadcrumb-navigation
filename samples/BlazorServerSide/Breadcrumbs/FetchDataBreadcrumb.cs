using Juniperr.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorServerSide.Breadcrumbs
{
    public class FetchDataBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(BreadcrumbBuilder builder)
        {
            builder.SetUrl("fetch-data");
            builder.SetTitle("Fetch data");

            return Task.CompletedTask;
        }
    }
}
