using Juniperr.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Juniperr.Blazor.BreadcrumbNavigation
{
    public sealed partial class BreadcrumbNavigation : IDisposable
    {
        [Parameter]
        public string CssClass { get; set; } = string.Empty;

        [CascadingParameter]
        public IBreadcrumbService BreadcrumbService { get; set; } = null!;

        private readonly IList<RenderFragment> _breadcrumbs = new List<RenderFragment>();

        protected override void OnInitialized()
        {
           BreadcrumbService.Added += HandleBreadcrumbAdded;
           BreadcrumbService.Reset += HandleBreadcrumbReset;
        }

        void IDisposable.Dispose()
        {
            BreadcrumbService.Added -= HandleBreadcrumbAdded;
            BreadcrumbService.Reset -= HandleBreadcrumbReset;
        }

        private void HandleBreadcrumbReset()
        {
            _breadcrumbs.Clear();
            StateHasChanged();
        }

        private void HandleBreadcrumbAdded(RenderFragment breadcrumb)
        {
            _breadcrumbs.Add(breadcrumb);
            StateHasChanged();
        }
    }
}
