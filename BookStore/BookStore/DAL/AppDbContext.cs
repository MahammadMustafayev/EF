using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DAL
{
    class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S22NJ7J\SQLEXPRESS;Database=BookStore;Trusted_Connection=True;");
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Pubslishing> Pubslishings { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<BookBuy> BookBuys { get; set; }
    }
}
