using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbService
    {
        public IBreadcrumbService Set<TBreadcrumb>(int index)
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(index, new Dictionary<string, object>());

        public IBreadcrumbService Set<TBreadcrumb>(int index, ParameterView parameters)
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(index, parameters.ToDictionary());

        IBreadcrumbService Set<TBreadcrumb>(int index, IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : Breadcrumb;
    }
}
