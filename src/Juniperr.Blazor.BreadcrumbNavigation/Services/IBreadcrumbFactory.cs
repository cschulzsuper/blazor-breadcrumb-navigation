using System;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbFactory
    {
        public IBreadcrumb Create<TBreadcrumb>()
            where TBreadcrumb : IBreadcrumb
            => Create(typeof(TBreadcrumb));

        IBreadcrumb Create(Type type);
    }
}
