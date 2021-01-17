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
            => BreadcrumbService.Added += HandleBreadcrumbAdded;

        void IDisposable.Dispose()
            => BreadcrumbService.Added -= HandleBreadcrumbAdded;

        private void HandleBreadcrumbAdded(int index, RenderFragment breadcrumb)
        {
            while (_breadcrumbs.Count > index)
                _breadcrumbs.Remove(_breadcrumbs.Last());

            _breadcrumbs.Add(breadcrumb);
            StateHasChanged();
        }
    }
}
