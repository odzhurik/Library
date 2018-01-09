using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Library.DAL
{
   public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            //options.
        }
        
        public DbSet<Book> Book { get; set; }
        public DbSet<Magazine> Magazine { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Book>().ToTable("Book");
           // modelBuilder.Entity<Magazine>().ToTable("Magazine");
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

        }
    }
    
}
