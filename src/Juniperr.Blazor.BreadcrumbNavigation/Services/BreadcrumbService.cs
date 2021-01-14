using Juniperr.Blazor.BreadcrumbNavigation.DataClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    internal class BreadcrumbService : IBreadcrumbService
    {
        internal event Action<int,BreadcrumbFragment>? OnBreadcrumbAdded;

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

            OnBreadcrumbAdded?.Invoke(
                index,
                new BreadcrumbFragment { 
                    BreadcrumbType = typeof(TBreadcrumb),
                    RenderFragment = renderFragment });

            return this;
        }
    }
}
