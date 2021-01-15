namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbBuilder
    {
        private readonly BreadcrumbProperties _breadcrumbProperties;

        internal BreadcrumbBuilder(BreadcrumbProperties breadcrumbProperties)
        {
            _breadcrumbProperties = breadcrumbProperties;
        }

        public BreadcrumbBuilder SetTitle(string title)
        {
            _breadcrumbProperties.Title = title;
            return this;
        }

        public BreadcrumbBuilder SetUrl(string url)
        {
            _breadcrumbProperties.Url = url;
            return this;
        }
    }
}
