using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class BookWriter
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int WriterId { get; set; }
        public Book Book { get; set; }
        public Writer Writer { get; set; }
    }
}
