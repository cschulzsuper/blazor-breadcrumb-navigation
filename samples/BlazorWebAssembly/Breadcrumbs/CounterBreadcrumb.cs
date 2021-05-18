using Microsoft.AspNetCore.Components;
using Supercode.Blazor.BreadcrumbNavigation.Services;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class CounterBreadcrumb : Breadcrumb
    {
        [Parameter]
        public int Counter { get; set; }

        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            builder.Link($"Counter {Counter}", "counter");

            return Task.CompletedTask;
        }
    }
}
