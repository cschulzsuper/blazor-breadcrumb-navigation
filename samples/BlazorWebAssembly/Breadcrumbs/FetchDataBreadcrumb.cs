using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class FetchDataBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            builder.Link("Fetch data", "fetch-data");

            return Task.CompletedTask;
        }
    }
}
