using System;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbBuilder
    {
        [Obsolete("SetTitle(string title) will be removed in the next version," +
                  " please use BreadcrumbBuilderExtensions.Text(this BreadcrumbBuilder builder, string title) instead.")]
        public BreadcrumbBuilder SetTitle(string title)
        {
            Title = title;

            return this;
        }

        [Obsolete("SetUrl(string url) will be removed in the next version," +
                  " please use BreadcrumbBuilderExtensions.Link(this BreadcrumbBuilder builder, string title, string url) instead.")]
        public BreadcrumbBuilder SetUrl(string url)
        {
            Url = url;

            return this;
        }

        public string? Title { get; set; }
        public Action? Action { get; set; }
        public string? Url { get; set; }
        public string? LeftIcon { get; set; }
        public Action? LeftAction { get; set; }
        public string? RightIcon { get; set; }
        public Action? RightAction { get; set; }
    }
}
