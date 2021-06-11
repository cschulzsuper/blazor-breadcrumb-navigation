using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using System;
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
            builder.OpenElement(0, "span");

            RenderLeftIcon(builder);

            builder.OpenComponent<NavLink>(0);
            builder.AddAttribute(1, "href", _breadcrumbProperties.Url);
            builder.AddAttribute(2, nameof(NavLink.Match), NavLinkMatch.All);
            builder.AddAttribute(3, nameof(NavLink.ChildContent),
                (RenderFragment)(innerBuilder => innerBuilder.AddContent(4, _breadcrumbProperties.Title)));
            builder.CloseComponent();

            RenderRightIcon(builder);

            builder.CloseComponent();
        }

        private void RenderFragementText(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "span");

            RenderLeftIcon(builder);
            builder.AddContent(1 , _breadcrumbProperties.Title);

            RenderRightIcon(builder);

            builder.CloseElement();
        }

        private void RenderLeftIcon(RenderTreeBuilder builder)
            => RenderIcon( builder,
                _breadcrumbProperties.LeftIcon,
                _breadcrumbProperties.LeftAction);

        private void RenderRightIcon( RenderTreeBuilder builder)
            => RenderIcon(builder, 
                _breadcrumbProperties.RightIcon, 
                _breadcrumbProperties.RightAction);

        private void RenderIcon(RenderTreeBuilder builder, string? icon, Action? action)
        {
            if (icon != null)
            {
                builder.OpenRegion(0);
                builder.OpenElement(1, action != null ? "button": "span");
                builder.AddAttribute(2, "class", icon);
                if (action != null)
                {
                    builder.AddAttribute(3, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, action));
                }
                builder.CloseElement();
                builder.CloseRegion();
            }
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
