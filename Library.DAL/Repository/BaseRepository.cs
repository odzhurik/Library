using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DapperExtensions;
using System.Data.Common;

namespace Library.DAL.Repository
{
   public abstract class BaseRepository<T> where T:class
    {
        protected DbTransaction Transaction { get; private set; }
        protected DbConnection Connection { get { return Transaction.Connection; } }
        public BaseRepository(DbTransaction transaction)
        {
            Transaction = transaction;
        }
        public  IEnumerable<T> GetAll() 
        {
            string query = $"select * from {typeof(T).Name}s";
            return Connection.Query<T>(query, transaction:Transaction);
        }
        public  T Get(int id)
        {
            string query = $"select * from {typeof(T).Name}s where Id=@id";
            return Connection.Query<T>(query, new { id=id}, transaction: Transaction).FirstOrDefault();
        }
        public void Create(T item) => Connection.Insert<T>(item);

        public void Update(T item) => Connection.Update<T>(item);
        public  void Delete(int id)
        {
            var model = Connection.Get<T>(id);
            Connection.Delete<T>(model);
        }
    }
}
