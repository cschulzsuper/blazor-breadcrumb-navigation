using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Collections.Generic;

namespace BlazorServerSide.Breadcrumbs
{
    public class IndexBreadcrumbLast : RootBreadcrumb
    {
        public override void Configure(BreadcrumbBuilder builder)
            => builder
                .LeftIcon("oi oi-home")
                .Link("Home", string.Empty,
                    new KeyValuePair<string, object>("aria-current", "page"));
    }
}
