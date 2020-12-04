namespace BookLand.Server.Data.Seeding
{
    using Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class BookSeeder : ISeeder
    {
        public async Task SeedAsync(BookLandDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Books.Any())
            {
                return;
            }

            await dbContext.Books.AddAsync(
                new Book 
                { 
                    Title = "Off Grid Life: Your Ideal Home in the Middle of Nowhere",

                });
        }
    }
}
