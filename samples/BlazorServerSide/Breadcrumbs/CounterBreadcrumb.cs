using Juniperr.Blazor.BreadcrumbNavigation.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerSide.Breadcrumbs
{
    public class CounterBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(BreadcrumbBuilder builder, IReadOnlyDictionary<string, object> parameters)
        {
            builder.SetUrl("/counter");
            builder.SetTitle("Counter");

            return Task.CompletedTask;
        }
    }
}
