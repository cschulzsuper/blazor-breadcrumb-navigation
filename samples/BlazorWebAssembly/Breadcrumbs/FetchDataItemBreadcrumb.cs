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

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public override Task ConfigureAsync(IBreadcrumbProperties builder)
        {
            var date = Date ?? DateTime.Today;

            builder.Text(date.ToShortDateString());
            builder.RightIcon("oi oi-x", () => NavigationManager.NavigateTo("/fetch-data"));

            return Task.CompletedTask;
        }
    }
}
