using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DbConnectionString
{
    public class ConnectionStrings : IConnectionString
    {
        private string _connectionString;
        public string LibraryDatabase { get; set; }
        public  string ConnectionStringValue
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
    }
}
