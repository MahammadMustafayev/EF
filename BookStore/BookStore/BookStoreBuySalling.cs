using BookStore.DAL;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class BookStoreBuySalling
    {
        public static void GetBuyBook(int id)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                if (!sql.Books.Any(b => b.Id == id)) return;
                Book book = sql.Books.SingleOrDefault(b => b.Id == id);
                sql.Remove(book);
                using (AppDbContext sql2 = new AppDbContext())
                {
                    BookBuy buy = new BookBuy { BookId = id };
                    sql2.Add(buy);
                }
                sql.SaveChanges();

            }
        }
        public static  void GetAll()
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Book> books = sql.Books.ToList();
                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.Id} .{book.Name}");
                }
            }
        }
    }
}
