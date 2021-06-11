using System;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbProperties : IBreadcrumbProperties
    {
        public string? Title { get; set; }
        public Action? Action { get; set; }
        public string? Url { get; set; }
        public string? LeftIcon { get; set; }
        public Action? LeftAction { get; set; }
        public string? RightIcon { get; set; }
        public Action? RightAction { get; set; }
    }
}
