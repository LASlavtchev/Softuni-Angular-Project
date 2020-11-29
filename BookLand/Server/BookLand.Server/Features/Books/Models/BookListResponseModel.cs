namespace BookLand.Server.Features.Books.Models
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class BookListResponseModel : IMapFrom<Book>
    {
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string AuthorFullName { get; set; }

        public string Language { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }
        
        public string Image { get; set; }
        
        public decimal Price { get; set; }

        public string PublisherName { get; set; }
    }
}
