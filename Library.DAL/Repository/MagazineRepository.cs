using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Library.DAL.Repository
{
   public class MagazineRepository :BaseRepository<Magazine>
    {
        public MagazineRepository(DbTransaction transaction) : base(transaction)
        {

        }
    }
}
