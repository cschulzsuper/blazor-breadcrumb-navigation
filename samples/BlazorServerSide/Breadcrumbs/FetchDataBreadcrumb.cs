using Supercode.Blazor.BreadcrumbNavigation.Services;

namespace BlazorServerSide.Breadcrumbs
{
    public class FetchDataBreadcrumb : Breadcrumb
    {
        public override void Configure(BreadcrumbBuilder builder)
            => builder.Link("Fetch data", "fetch-data");
    }
}
