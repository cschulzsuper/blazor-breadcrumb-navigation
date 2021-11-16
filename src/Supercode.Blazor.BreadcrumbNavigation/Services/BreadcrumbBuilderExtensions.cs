using System;
using System.Collections.Generic;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public static class BreadcrumbBuilderExtensions
    {
        public static BreadcrumbBuilder Text(this BreadcrumbBuilder builder, string title, params KeyValuePair<string, object>[] attributes)
        {
            builder.Title = title;
            builder.Action = null;
            builder.Url = null;
            builder.Attributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder Link(this BreadcrumbBuilder builder, string title, string url, params KeyValuePair<string, object>[] attributes)
        {
            builder.Title = title;
            builder.Action = null;
            builder.Url = url;
            builder.Attributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder Action(this BreadcrumbBuilder builder, string title, Action action, params KeyValuePair<string, object>[] attributes)
        {
            builder.Title = title;
            builder.Action = action;
            builder.Url = null;
            builder.Attributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder LeftIcon(this BreadcrumbBuilder builder, string css, params KeyValuePair<string, object>[] attributes)
        {
            builder.LeftIcon = css;
            builder.LeftAction = null;
            builder.LeftAttributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder LeftIcon(this BreadcrumbBuilder builder, string css, Action action, params KeyValuePair<string, object>[] attributes)
        {
            builder.LeftIcon = css;
            builder.LeftAction = action;
            builder.LeftAttributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder RightIcon(this BreadcrumbBuilder builder, string css, params KeyValuePair<string, object>[] attributes)
        {
            builder.RightIcon = css;
            builder.RightAction = null;
            builder.RightAttributes = attributes;

            return builder;
        }

        public static BreadcrumbBuilder RightIcon(this BreadcrumbBuilder builder, string css, Action action, params KeyValuePair<string, object>[] attributes)
        {
            builder.RightIcon = css;
            builder.RightAction = action;
            builder.RightAttributes = attributes;

            return builder;
        }
    }
}
