using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbService
    {
        event Action<int, RenderFragment>? Added;

        public IBreadcrumbService Set<TBreadcrumb>(int index)
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(index, new Dictionary<string, object>());

        public IBreadcrumbService Set<TBreadcrumb>(int index, ParameterView parameters)
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(index, parameters.ToDictionary());

        IBreadcrumbService Set<TBreadcrumb>(int index, IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : Breadcrumb;
    }
}
