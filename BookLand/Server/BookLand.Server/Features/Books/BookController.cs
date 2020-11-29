namespace BookLand.Server.Features.Books
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Infrastructure.Extensions;
    using Features.Books.Models;
    using System.Collections.Generic;

    public class BookController : ApiController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<IEnumerable<BookListResponseModel>> All()
        {
            var books = await this.bookService.GetAll<BookListResponseModel>();

            return books;
        }
    }
}
