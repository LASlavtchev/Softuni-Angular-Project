namespace BookLand.Server.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    using static ValidationConstants.Book;

    public class Book
    {
        public Book()
        {
            this.CategoryBooks = new HashSet<CategoryBook>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        
        [Required]
        [MaxLength(MaxLanguageLength)]
        public string Language { get; set; }
       
        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [MaxLength(MaxISBNLength)]
        public string ISBN { get; set; }

        [Required]
        public string Image { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(typeof(decimal), MinPrice, MaxPrice)]
        public decimal Price { get; set; }

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<CategoryBook> CategoryBooks { get; set; }
    }
}
