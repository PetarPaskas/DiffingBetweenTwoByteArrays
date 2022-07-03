using Descartes.Helpers;
using Descartes.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Descartes
{
    public static class Extensions
    {
        public static void AddDescartesContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DescartesContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }

        public static void AddDescartesDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IDiffingHelper, DiffingHelper>();
        }
    }
}
