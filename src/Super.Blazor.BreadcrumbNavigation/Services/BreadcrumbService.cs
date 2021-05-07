using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Super.Blazor.BreadcrumbNavigation.Services
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
            where TBreadcrumb : Breadcrumb
        {
            var renderFragment = new RenderFragment(builder =>
            {
                builder.OpenComponent<TBreadcrumb>(0);

                var i = 1;
                foreach (var (key, value) in parameters)
                {
                    builder.AddAttribute(i++, key, value);
                }

                builder.CloseComponent();
            });

            Added?.Invoke(renderFragment);
            return this;
        }
    }
}
