using System;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    internal class BreadcrumbFactory : IBreadcrumbFactory
    {
        public IBreadcrumb Create(Type breadcrumbType)
        {
            if (!typeof(IBreadcrumb).IsAssignableFrom(breadcrumbType))
            {
                throw new ArgumentException($"{breadcrumbType.Name} must implement IBreadcrumb");
            }

            return (IBreadcrumb)Activator.CreateInstance(breadcrumbType)!;
        }
    }
}
