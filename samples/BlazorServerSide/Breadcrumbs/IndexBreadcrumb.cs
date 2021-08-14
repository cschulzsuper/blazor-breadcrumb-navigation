﻿using Supercode.Blazor.BreadcrumbNavigation.Services;

namespace BlazorServerSide.Breadcrumbs
{
    public class IndexBreadcrumb : RootBreadcrumb
    {
        public override void Configure(BreadcrumbBuilder builder)
            => builder
                .LeftIcon("oi oi-home")
                .Link("Home", string.Empty);
    }
}
