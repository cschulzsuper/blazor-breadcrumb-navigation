namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public static class BreadcrumbExtensions
    {
        public static IBreadcrumbProperties Text(this IBreadcrumbProperties breadcrumbProperties, string title)
        {
            if(breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.Title = title;
                typedBreadcrumbProperties.Url = null;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties Link(this IBreadcrumbProperties breadcrumbProperties, string title, string url)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.Title = title;
                typedBreadcrumbProperties.Url = url;
            }

            return breadcrumbProperties;
        }
    }
}
