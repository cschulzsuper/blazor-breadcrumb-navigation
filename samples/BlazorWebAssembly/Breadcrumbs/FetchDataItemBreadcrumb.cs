using Supercode.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class FetchDataItemBreadcrumb : Breadcrumb
    {
        [Parameter]
        public DateTime? Date { get; set; }

        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            var date = Date ?? DateTime.Today;

            builder.Text(date.ToShortDateString());

            return Task.CompletedTask;
        }
    }
}
