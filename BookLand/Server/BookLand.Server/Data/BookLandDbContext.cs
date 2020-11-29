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

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryBook> CategoryBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            builder
                .Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId);

            builder.Entity<CategoryBook>()
                .HasOne(cb => cb.Category)
                .WithMany(b => b.CategoryBooks)
                .HasForeignKey(cb => cb.CategoryId);

            builder.Entity<CategoryBook>()
                .HasOne(cb => cb.Book)
                .WithMany(b => b.CategoryBooks)
                .HasForeignKey(cb => cb.BookId);

            builder
                .Entity<CategoryBook>()
                .HasKey(cb => new { cb.CategoryId, cb.BookId });

            base.OnModelCreating(builder);
        }
    }
}
