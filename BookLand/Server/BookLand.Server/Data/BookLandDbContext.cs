namespace BookLand.Server.Data
{
    using BookLand.Server.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class BookLandDbContext : IdentityDbContext<User>
    {
        public BookLandDbContext(DbContextOptions<BookLandDbContext> options)
            : base(options)
        {
        }
    }
}
