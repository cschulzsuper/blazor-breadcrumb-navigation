using Juniperr.Blazor.BreadcrumbNavigation.DataClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Juniperr.Blazor.BreadcrumbNavigation
{
    public sealed partial class BreadcrumbNavigation
    {
        [CascadingParameter] private ICollection<BreadcrumbFragment> Breadcrumbs { get; set; } = null!;

    }
}
