using Juniperr.Blazor.BreadcrumbNavigation.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Juniperr.Blazor.BreadcrumbNavigation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJuniperrBreadcrumbNavigation(this IServiceCollection services)
            => services.AddScoped<IBreadcrumbService, BreadcrumbService>();
    }
}
