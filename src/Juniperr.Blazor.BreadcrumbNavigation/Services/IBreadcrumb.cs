using System.Collections.Generic;
using System.Threading.Tasks;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumb
    {
        Task ConfigureAsync(BreadcrumbBuilder builder, IReadOnlyDictionary<string, object> parameters);
    }
}
