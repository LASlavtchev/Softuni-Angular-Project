namespace BookLand.Server.Infrastructure.Extensions
{
    using BookLand.Server.Data.Seeding;
    using Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerUI(this IApplicationBuilder app)
        {
            app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My BookLand API");
                    options.RoutePrefix = string.Empty;
                });

            return app;
        }

        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var serserviceScope = app.ApplicationServices.CreateScope();

            var dbContext = serserviceScope.ServiceProvider.GetService<BookLandDbContext>();

            dbContext.Database.Migrate();

            new BookLandDbContextSeeder()
                .SeedAsync(dbContext, serserviceScope.ServiceProvider)
                .GetAwaiter()
                .GetResult();
        }
    }
}
