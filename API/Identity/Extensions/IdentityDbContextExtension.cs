using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Identity.Extensions
{
    public static class IdentityDbContextExtensions
    {
        public static IServiceCollection AddIdentityDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("IdentityConnection")));
            return services;
        }
    }

}