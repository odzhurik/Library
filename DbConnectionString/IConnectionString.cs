using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DbConnectionString
{
   public interface IConnectionString
    {
        string ConnectionStringValue { get; }
     string LibraryDatabase { get; set; }
    }
}
