namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbBuilder
    {
        private readonly BreadcrumbInfo _breadcrumbInstance;

        internal BreadcrumbBuilder(BreadcrumbInfo breadcrumbInstance)
        {
            _breadcrumbInstance = breadcrumbInstance;
        }

        public BreadcrumbBuilder SetTitle(string title)
        {
            _breadcrumbInstance.Title = title;
            return this;
        }

        public BreadcrumbBuilder SetUrl(string url)
        {
            _breadcrumbInstance.Url = url;
            return this;
        }
    }
}
