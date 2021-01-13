using Juniperr.Blazor.BreadcrumbNavigation.DataClasses;
using Juniperr.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation
{
    public sealed partial class CascadingBreadcrumbNavigation : ComponentBase, IDisposable
    {
        [Inject] public IBreadcrumbService BreadcrumbService { get; set; } = null!;

        [Parameter] public RenderFragment ChildContent { get; set; } = null!;

        private readonly IList<BreadcrumbFragment> Breadcrumbs = new List<BreadcrumbFragment>();

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            ((BreadcrumbService)BreadcrumbService).OnBreadcrumbAdded += BreadcrumbAdded;
        }

        void IDisposable.Dispose()
        {
            ((BreadcrumbService)BreadcrumbService).OnBreadcrumbAdded -= BreadcrumbAdded;
        }

        private void BreadcrumbAdded(int index, BreadcrumbFragment breadcrumb)
        {
            while(Breadcrumbs.Count > index) { 
                Breadcrumbs.Remove(Breadcrumbs.Last());
            }

            var breadcrumbExists = Breadcrumbs.Any(x => x.BreadcrumbType == breadcrumb.BreadcrumbType);
            if (breadcrumbExists)
            {
                return;
            }

            Breadcrumbs.Add(breadcrumb);
        }
    }
}
