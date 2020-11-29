namespace BookLand.Server.Data.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public Category()
        {
            this.CategoryBooks = new HashSet<CategoryBook>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CategoryBook> CategoryBooks { get; set; }
    }
}
