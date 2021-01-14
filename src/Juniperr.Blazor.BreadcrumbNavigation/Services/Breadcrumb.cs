using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public abstract class Breadcrumb : ComponentBase
    {
        private readonly BreadcrumbInfo _breadcrumbInstance = new BreadcrumbInfo();

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<NavLink>(0);
            builder.AddAttribute(1, "href", _breadcrumbInstance.Url);
            builder.AddAttribute(2, "Match", NavLinkMatch.All);
            builder.AddAttribute(3, "ChildContent", (RenderFragment)((innerBuilder) =>
            {
                innerBuilder.AddContent(4, _breadcrumbInstance.Title);
            }));
            builder.CloseComponent();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            var builder = new BreadcrumbBuilder(_breadcrumbInstance);
            ConfigureAsync(builder, parameters.ToDictionary());
            return base.SetParametersAsync(parameters);
        }

        public abstract Task ConfigureAsync(BreadcrumbBuilder builder, IReadOnlyDictionary<string, object> parameters);
    }
}
