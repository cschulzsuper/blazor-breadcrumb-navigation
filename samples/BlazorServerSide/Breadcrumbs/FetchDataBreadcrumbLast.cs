using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Collections.Generic;

namespace BlazorServerSide.Breadcrumbs
{
    public class FetchDataBreadcrumbLast : Breadcrumb
    {
        public override void Configure(BreadcrumbBuilder builder)
            => builder.Link("Fetch data", "fetch-data",
                new KeyValuePair<string, object>("aria-current", "page"));
    }
}
