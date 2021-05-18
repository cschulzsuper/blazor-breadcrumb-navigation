namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbProperties : IBreadcrumbProperties
    {
        public string Title { get; set; } = string.Empty;
        public string? Url { get; set; }
    }
}
