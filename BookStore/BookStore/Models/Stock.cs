using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int StockCount { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public List<Book> Books { get; set; }
    }
}
