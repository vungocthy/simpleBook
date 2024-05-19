using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookCatalogDbContext:DbContext
    {
        public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(100);
        //    modelBuilder.Entity<Book>().Property(e => e.Author).IsRequired().HasMaxLength(100);
        //}
    }
}
