using Supercode.Blazor.BreadcrumbNavigation.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Supercode.Blazor.BreadcrumbNavigation
{
    public partial class BreadcrumbNavigation : IDisposable
    {
        [Parameter]
        public string CssClass { get; set; } = string.Empty;

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> AdditionalAttributes { get; set; } = null!;

        [CascadingParameter]
        public IBreadcrumbService BreadcrumbService { get; set; } = null!;

        private readonly IList<RenderFragment> _breadcrumbs = new List<RenderFragment>();

        protected override void OnInitialized()
        {
           BreadcrumbService.Added += HandleBreadcrumbAdded;
           BreadcrumbService.Reset += HandleBreadcrumbReset;
        }

        public virtual void Dispose()
        {
            BreadcrumbService.Added -= HandleBreadcrumbAdded;
            BreadcrumbService.Reset -= HandleBreadcrumbReset;

            GC.SuppressFinalize(this);
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
