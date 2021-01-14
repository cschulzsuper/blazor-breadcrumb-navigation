﻿using Juniperr.Blazor.BreadcrumbNavigation.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Breadcrumbs
{
    public class IndexBreadcrumb : Breadcrumb
    {
        public override Task ConfigureAsync(BreadcrumbBuilder builder, IReadOnlyDictionary<string, object> parameters)
        {
            builder.SetUrl(string.Empty);
            builder.SetTitle("Home");

            return Task.CompletedTask;
        }
    }
}
