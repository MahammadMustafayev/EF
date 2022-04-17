using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
   public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookWriter> BookWriters { get; set; }
    }
}
