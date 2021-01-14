using Juniperr.Blazor.BreadcrumbNavigation.DataClasses;
using Juniperr.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation
{
    public sealed partial class CascadingBreadcrumbNavigation : ComponentBase
    {
        [Inject] public IBreadcrumbService BreadcrumbService { get; set; } = null!;

        [Parameter] public RenderFragment ChildContent { get; set; } = null!;
    }
}
