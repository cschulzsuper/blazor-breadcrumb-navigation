using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbService
    {
        event Action<RenderFragment>? Added;

        event Action? Reset;

        public IBreadcrumbService Clear();

        public IBreadcrumbService Set<TBreadcrumb>()
            where TBreadcrumb : IComponent
            => Set<TBreadcrumb>(new Dictionary<string, object>());

        public IBreadcrumbService Set<TBreadcrumb>(ParameterView parameters)
            where TBreadcrumb : IComponent
            => Set<TBreadcrumb>(parameters.ToDictionary());

        IBreadcrumbService Set<TBreadcrumb>(IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : IComponent;
    }
}
