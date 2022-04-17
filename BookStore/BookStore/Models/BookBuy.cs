using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class BookBuy
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
