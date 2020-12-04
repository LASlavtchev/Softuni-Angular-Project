namespace BookLand.Server.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(BookLandDbContext dbContext, IServiceProvider serviceProvider);
    }
}
