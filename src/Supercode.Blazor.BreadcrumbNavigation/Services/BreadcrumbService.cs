using Microsoft.AspNetCore.Components;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    class BreadcrumbService : IBreadcrumbService
    {
        public event Action<RenderFragment>? Added;

        public event Action? Reset;

        public IBreadcrumbService Clear()
        {
            Reset?.Invoke();
            return this;
        }

        public IBreadcrumbService Set<TBreadcrumb>(IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : IComponent
        {
            ClearIfRootBreadcrumb<TBreadcrumb>();
            AddComponent<TBreadcrumb>(parameters);

            return this;
        }

        private void ClearIfRootBreadcrumb<TBreadcrumb>()
            where TBreadcrumb : IComponent
        {
            var isRootBreadcrumb = typeof(TBreadcrumb)
                .GetCustomAttributes<RootBreadcrumbAttribute>()
                .Any();

            if(isRootBreadcrumb)
            {
                Clear();
            }
        }

        private void AddComponent<TBreadcrumb>(IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : IComponent
        {
            var renderFragment = new RenderFragment(builder =>
            {
                builder.OpenComponent(0, typeof(TBreadcrumb));
                builder.AddMultipleAttributes(1, parameters.ToList());
                builder.CloseComponent();
            });

            Added?.Invoke(renderFragment);
        }
    }
}
