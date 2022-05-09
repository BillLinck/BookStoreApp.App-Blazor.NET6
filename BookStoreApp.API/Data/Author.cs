using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public byte[]? LastName { get; set; }
        public byte[]? Bio { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
