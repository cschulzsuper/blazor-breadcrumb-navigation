using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    internal class BreadcrumbService : IBreadcrumbService
    {
        public event Action<int, RenderFragment>? Added;

        public IBreadcrumbService Set<TBreadcrumb>(int index, IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : Breadcrumb
        {
            var renderFragment = new RenderFragment(builder =>
            {
                builder.OpenComponent<TBreadcrumb>(0);

                var i = 1;
                foreach (var parameter in parameters)
                {
                    builder.AddAttribute(i++, parameter.Key, parameter.Value);
                }

                builder.CloseComponent();
            });

            Added?.Invoke( index, renderFragment);
            return this;
        }
    }
}
