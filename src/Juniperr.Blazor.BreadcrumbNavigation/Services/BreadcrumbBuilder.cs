using Juniperr.Blazor.BreadcrumbNavigation.DataClasses;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbBuilder
    {
        internal BreadcrumbBuilder()
        {
        }

        internal BreadcrumbInstance Instance { get; } = new BreadcrumbInstance();

        public BreadcrumbBuilder Title(string title)
        {
            Instance.Title = title;
            return this;
        }

        public BreadcrumbBuilder Href(string href)
        {
            Instance.Href = href;
            return this;
        }
    }
}
