﻿namespace BookLand.Server.Infrastructure
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ConfigurationExtensions
    {
        public static string GetDefaultConnectionString(this IConfiguration configuration)
        {
            return configuration.GetConnectionString("DefaultConnection");
        }
        
        public static AppSettings GetApplicationSettings(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var appSettingConfiguration = configuration.GetSection("ApplicationSettings");

            services.Configure<AppSettings>(appSettingConfiguration);

            var appSettings = appSettingConfiguration.Get<AppSettings>();

            return appSettings;
        }
    }
}
