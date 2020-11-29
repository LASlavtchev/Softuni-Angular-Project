namespace BookLand.Server.Features.Books.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.ValidationConstants.Book;

    public class CreateRequestModel
    {
        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        [Required]
        [MaxLength(MaxLanguageLength)]
        public string Language { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [MaxLength(MaxDescriptionLength)]
        public string ISBN { get; set; }

        [Required]
        public string Image { get; set; }

        [Range(typeof(decimal), MinPrice, MaxPrice)]
        public decimal Price { get; set; }

        //public IEnumerable<SelectListItem> Authors { get; set; }
        //public IEnumerable<SelectListItem> Publishers { get; set; }
    }
}
