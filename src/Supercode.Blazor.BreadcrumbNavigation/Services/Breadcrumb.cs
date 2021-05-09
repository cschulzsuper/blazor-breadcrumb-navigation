using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.Threading.Tasks;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public abstract class Breadcrumb : IComponent
    {
        private readonly BreadcrumbProperties _breadcrumbInstance = new BreadcrumbProperties();
        private readonly RenderFragment _renderFragment;

        private RenderHandle _renderHandle;

        protected Breadcrumb()
            => _renderFragment = builder =>
            {
                builder.OpenComponent<NavLink>(0);
                builder.AddAttribute(1, "href", _breadcrumbInstance.Url);
                builder.AddAttribute(2, nameof(NavLink.Match), NavLinkMatch.All);
                builder.AddAttribute(3, nameof(NavLink.ChildContent),
                    (RenderFragment) (innerBuilder => innerBuilder.AddContent(4, _breadcrumbInstance.Title)));
                builder.CloseComponent();
            };

        public void Attach(RenderHandle renderHandle)
            => _renderHandle = renderHandle;

        public async Task SetParametersAsync(ParameterView parameters)
        {
            parameters.SetParameterProperties(this);
            await ConfigureAsync(
                new BreadcrumbBuilder(_breadcrumbInstance));
            _renderHandle.Render(_renderFragment);
        }

        public abstract Task ConfigureAsync(BreadcrumbBuilder builder);

    }
}
