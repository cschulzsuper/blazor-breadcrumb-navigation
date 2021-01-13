using Juniperr.Blazor.BreadcrumbNavigation.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Juniperr.Blazor.BreadcrumbNavigation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJuniperrBreadcrumbNavigation(this IServiceCollection services)
            => services.AddJuniperrBreadcrumbNavigation<BreadcrumbFactory>();

        public static IServiceCollection AddJuniperrBreadcrumbNavigation<TBreadcrumbFactory>(this IServiceCollection services)
            where TBreadcrumbFactory : class, IBreadcrumbFactory
            => services
                .AddScoped<IBreadcrumbService, BreadcrumbService>()
                .AddScoped<IBreadcrumbFactory, TBreadcrumbFactory>();

        public static IServiceCollection AddJuniperrBreadcrumb<TBreadcrumb>(this IServiceCollection services)
             where TBreadcrumb : class, IBreadcrumb
             => services.AddTransient<TBreadcrumb>();
    }
}
