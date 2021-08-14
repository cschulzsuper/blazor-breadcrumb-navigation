using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class FetchDataBreadcrumb : Breadcrumb
    {
        public override void Configure(BreadcrumbBuilder builder)
            => builder.Link("Fetch data", "fetch-data");
    }
}
