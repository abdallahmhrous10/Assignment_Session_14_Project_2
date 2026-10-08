using Microsoft.EntityFrameworkCore;
using Project_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2.Data
{
    public class MyAppContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-P51CPJRR\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                  .HasKey(x => new
                  {
                      x.BookId,
                      x.BorrowerId
                  });
        }
    }
}
