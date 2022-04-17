using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Page
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public List<Book> Books { get; set; }
    }
}
