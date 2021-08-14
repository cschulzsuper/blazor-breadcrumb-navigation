﻿using Supercode.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class FetchDataItemBreadcrumb : Breadcrumb
    {
        [Parameter]
        public DateTime? Date { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public override async Task ConfigureAsync(BreadcrumbBuilder builder)
        {
            builder.Text("Loading...");

            await Task.Delay(1000);

            var date = Date ?? DateTime.Today;

            builder.Text(date.ToShortDateString());
            builder.RightIcon("oi oi-x", () => NavigationManager.NavigateTo($"{NavigationManager.BaseUri}fetch-data"));
        }
    }
}
