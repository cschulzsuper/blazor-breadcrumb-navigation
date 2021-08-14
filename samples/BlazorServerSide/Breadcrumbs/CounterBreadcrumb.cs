using Microsoft.AspNetCore.Components;
using Supercode.Blazor.BreadcrumbNavigation.Services;

namespace BlazorServerSide.Breadcrumbs
{
    public class CounterBreadcrumb : Breadcrumb
    {
        [Parameter]
        public int Counter { get; set; }

        public override void Configure(BreadcrumbBuilder builder)
            => builder.Link($"Counter {Counter}", "counter");
    }
}
