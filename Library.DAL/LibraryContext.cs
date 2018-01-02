using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Library.DAL
{
   public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            //options.
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        // IConfigurationRoot configuration = new ConfigurationBuilder()
        //        //.SetBasePath(System.AppContext.BaseDirectory)
        //        //.AddJsonFile("appsettings.json")
        //        ////  optional: true,
        //        ////  reloadOnChange: true)
        //        //.Build();
        //        // optionsBuilder.UseSqlServer(/*configuration.GetConnectionString("LibraryDatabase")*/ ConnectionString);
        //       // string connstr = ConfigurationManager.ConnectionStrings["LibraryDatabase"].ToString();
        //        optionsBuilder.UseSqlServer(@"'Data Source=User-PC;Initial Catalog=LibraryDB;Integrated Security=True;' name = 'LibraryDatabase' providername = 'System.Data.SqlClient'");
        //    }
        //}
        public DbSet<Book> Books { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
    }
    
}
