namespace BookLand.Server.Features.Books
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Extensions;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            return await this.bookRepository
                .All()
                .To<T>()
                .ToListAsync();
        }
    }
}
