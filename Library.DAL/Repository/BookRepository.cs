using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Library.DAL.Repository
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(DbTransaction transaction):base(transaction)
        {
                
        }
        
    }
}
