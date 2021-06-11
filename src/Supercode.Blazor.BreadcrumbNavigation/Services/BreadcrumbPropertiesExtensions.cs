using System;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public static class BreadcrumbPropertiesExtensions
    {
        public static IBreadcrumbProperties Text(this IBreadcrumbProperties breadcrumbProperties, string title)
        {
            if(breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.Title = title;
                typedBreadcrumbProperties.Action = null;
                typedBreadcrumbProperties.Url = null;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties Link(this IBreadcrumbProperties breadcrumbProperties, string title, string url)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.Title = title;
                typedBreadcrumbProperties.Action = null;
                typedBreadcrumbProperties.Url = url;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties Action(this IBreadcrumbProperties breadcrumbProperties, string title, Action action)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.Title = title;
                typedBreadcrumbProperties.Action = action;
                typedBreadcrumbProperties.Url = null;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties LeftIcon(this IBreadcrumbProperties breadcrumbProperties, string css)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.LeftIcon = css;
                typedBreadcrumbProperties.LeftAction = null;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties LeftIcon(this IBreadcrumbProperties breadcrumbProperties, string css, Action action)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.LeftIcon = css;
                typedBreadcrumbProperties.LeftAction = action;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties RightIcon(this IBreadcrumbProperties breadcrumbProperties, string css)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.RightIcon = css;
                typedBreadcrumbProperties.RightAction = null;
            }

            return breadcrumbProperties;
        }

        public static IBreadcrumbProperties RightIcon(this IBreadcrumbProperties breadcrumbProperties, string css, Action action)
        {
            if (breadcrumbProperties is BreadcrumbProperties typedBreadcrumbProperties)
            {
                typedBreadcrumbProperties.RightIcon = css;
                typedBreadcrumbProperties.RightAction = action;
            }

            return breadcrumbProperties;
        }
    }
}
