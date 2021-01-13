using Microsoft.AspNetCore.Components;
using System;

namespace Juniperr.Blazor.BreadcrumbNavigation.DataClasses
{
    internal class BreadcrumbFragment
    {
        public Type BreadcrumbType { get; init; } = null!;
        public RenderFragment RenderFragment { get; init; } = null!;
    }
}
