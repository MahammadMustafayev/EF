using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookGenre> BookGenres { get; set; }
        public List<BookWriter> BookWriters { get; set; }
        public int PageId { get; set; }
        public int PunslishingId { get; set; }
        public Page Page { get; set; }
        public Pubslishing Pubslishing { get; set; }
      
    }
}
