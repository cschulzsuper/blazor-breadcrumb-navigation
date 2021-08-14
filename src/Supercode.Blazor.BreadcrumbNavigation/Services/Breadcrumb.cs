using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Threading.Tasks;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public abstract class Breadcrumb : ComponentBase
    {
        private readonly BreadcrumbBuilder _breadcrumbBuilder = new();

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (_breadcrumbBuilder.Url == null)
            {
                RenderFragmentText(builder);
            }
            else
            {
                RenderFragmentNavLink(builder);
            }
        }

        private void RenderFragmentNavLink(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "span");

            RenderLeftIcon(builder);

            builder.OpenComponent<NavLink>(0);
            builder.AddAttribute(1, "href", _breadcrumbBuilder.Url);
            builder.AddAttribute(2, nameof(NavLink.Match), NavLinkMatch.All);
            builder.AddAttribute(3, nameof(NavLink.ChildContent),
                (RenderFragment)(innerBuilder => innerBuilder.AddContent(4, _breadcrumbBuilder.Title)));
            builder.CloseComponent();

            RenderRightIcon(builder);

            builder.CloseComponent();
        }

        private void RenderFragmentText(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "span");

            RenderLeftIcon(builder);

            builder.AddContent(1 , _breadcrumbBuilder.Title);

            RenderRightIcon(builder);

            builder.CloseElement();
        }

        private void RenderLeftIcon(RenderTreeBuilder builder)
            => RenderIcon( builder,
                _breadcrumbBuilder.LeftIcon,
                _breadcrumbBuilder.LeftAction);

        private void RenderRightIcon( RenderTreeBuilder builder)
            => RenderIcon(builder, 
                _breadcrumbBuilder.RightIcon, 
                _breadcrumbBuilder.RightAction);

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

        protected override void OnParametersSet()
            => Configure(_breadcrumbBuilder);

        protected override Task OnParametersSetAsync()
            => ConfigureAsync(_breadcrumbBuilder);

        public virtual Task ConfigureAsync(BreadcrumbBuilder builder)
            => Task.CompletedTask;

        public virtual void Configure(BreadcrumbBuilder builder)
        {
        }
    }
}
