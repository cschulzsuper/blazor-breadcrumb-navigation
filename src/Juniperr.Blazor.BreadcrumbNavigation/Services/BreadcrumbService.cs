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
        private readonly IBreadcrumbFactory _breadcrumbFactory;

        internal event Action<int,BreadcrumbFragment>? OnBreadcrumbAdded;

        public BreadcrumbService(IBreadcrumbFactory breadcrumbFactory)
        {
            _breadcrumbFactory = breadcrumbFactory;
        }

        public async Task<IBreadcrumbService> SetAsync<TBreadcrumb>(int index, IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : IBreadcrumb
        {
            var breadcrumbBuilder = new BreadcrumbBuilder();
            var breadcrumbInstance = breadcrumbBuilder.Instance;
            var breadcrumb = _breadcrumbFactory.Create<TBreadcrumb>();

            await breadcrumb.ConfigureAsync(breadcrumbBuilder, parameters);

            var renderFragment = new RenderFragment(builder =>
            {
                builder.OpenComponent<NavLink>(0);
                builder.AddAttribute(1, "href", breadcrumbInstance.Href);
                builder.AddAttribute(2, "Match", NavLinkMatch.All);
                builder.AddAttribute(3, "ChildContent", (RenderFragment)((innerBuilder) =>
                {
                    innerBuilder.AddContent(4, breadcrumbInstance.Title);
                }));
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
