namespace BookLand.Server.Data.Models
{
    using System.Collections.Generic;

    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{this.FirstName} {this.LastName}"; }
        }

        public virtual ICollection<Book> Books { get; set; }
    }
}
