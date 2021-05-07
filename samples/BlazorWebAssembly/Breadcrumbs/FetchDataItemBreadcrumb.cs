using Super.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class FetchDataItemBreadcrumb : Breadcrumb
    {
        [Parameter]
        public DateTime? Date { get; set; }

        public override Task ConfigureAsync(BreadcrumbBuilder builder)
        {
            var date = Date ?? DateTime.Today;

            builder.SetUrl($"fetch-data/{date:yyyy-MM-dd}");
            builder.SetTitle(date.ToShortDateString());

            return Task.CompletedTask;
        }
    }
}
