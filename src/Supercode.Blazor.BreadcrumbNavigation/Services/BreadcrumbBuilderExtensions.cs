using System;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public static class BreadcrumbBuilderExtensions
    {
        public static BreadcrumbBuilder Text(this BreadcrumbBuilder builder, string title)
        {
            builder.Title = title;
            builder.Action = null;
            builder.Url = null;

            return builder;
        }

        public static BreadcrumbBuilder Link(this BreadcrumbBuilder builder, string title, string url)
        {
            builder.Title = title;
            builder.Action = null;
            builder.Url = url;

            return builder;
        }

        public static BreadcrumbBuilder Action(this BreadcrumbBuilder builder, string title, Action action)
        {
            builder.Title = title;
            builder.Action = action;
            builder.Url = null;

            return builder;
        }

        public static BreadcrumbBuilder LeftIcon(this BreadcrumbBuilder builder, string css)
        {
            builder.LeftIcon = css;
            builder.LeftAction = null;

            return builder;
        }

        public static BreadcrumbBuilder LeftIcon(this BreadcrumbBuilder builder, string css, Action action)
        {
            builder.LeftIcon = css;
            builder.LeftAction = action;

            return builder;
        }

        public static BreadcrumbBuilder RightIcon(this BreadcrumbBuilder builder, string css)
        {
            builder.RightIcon = css;
            builder.RightAction = null;

            return builder;
        }

        public static BreadcrumbBuilder RightIcon(this BreadcrumbBuilder builder, string css, Action action)
        {
            builder.RightIcon = css;
            builder.RightAction = action;

            return builder;
        }
    }
}
