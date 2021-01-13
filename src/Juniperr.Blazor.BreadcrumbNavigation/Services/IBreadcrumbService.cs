using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbService
    {
        public Task<IBreadcrumbService> SetAsync<TBreadcrumb>(int index)
            where TBreadcrumb : IBreadcrumb
            => SetAsync<TBreadcrumb>(index, new Dictionary<string, object>());

        public Task<IBreadcrumbService> SetAsync<TBreadcrumb>(int index, ParameterView parameters)
            where TBreadcrumb : IBreadcrumb
            => SetAsync<TBreadcrumb>(index, parameters.ToDictionary());

        Task<IBreadcrumbService> SetAsync<TBreadcrumb>(int index, IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : IBreadcrumb;
    }
}
