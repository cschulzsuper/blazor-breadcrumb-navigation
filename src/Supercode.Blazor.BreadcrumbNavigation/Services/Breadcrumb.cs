using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;
using System.Threading.Tasks;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public abstract class Breadcrumb : IComponent
    {
        public BreadcrumbProperties _breadcrumbProperties = new();

        private readonly RenderFragment _renderFragment;

        private RenderHandle _renderHandle;

        protected Breadcrumb()
        {
            _renderFragment = builder =>
            {
                if (_breadcrumbProperties.Url == null)
                {
                    RenderFragementText(builder);
                }
                else
                {
                    RenderFragementNavLink(builder);
                }
            };
        }

        private void RenderFragementNavLink(RenderTreeBuilder builder)
        {
            builder.OpenComponent<NavLink>(0);
            builder.AddAttribute(1, "href", _breadcrumbProperties.Url);
            builder.AddAttribute(2, nameof(NavLink.Match), NavLinkMatch.All);
            builder.AddAttribute(3, nameof(NavLink.ChildContent),
                (RenderFragment)(innerBuilder => innerBuilder.AddContent(4, _breadcrumbProperties.Title)));
            builder.CloseComponent();
        }

        private void RenderFragementText(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "span");
            builder.AddContent(1, _breadcrumbProperties.Title);
            builder.CloseElement();
        }

        public void Attach(RenderHandle renderHandle)
            => _renderHandle = renderHandle;

        public async Task SetParametersAsync(ParameterView parameters)
        {
            parameters.SetParameterProperties(this);
            await ConfigureAsync(_breadcrumbProperties);
            _renderHandle.Render(_renderFragment);
        }

        public abstract Task ConfigureAsync(IBreadcrumbProperties breadcrumbProperties);

    }
}
