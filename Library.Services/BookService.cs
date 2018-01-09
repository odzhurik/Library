using Library.DAL.UnitOfWork;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Services
{
   public class BookService :BaseService
    {
        public BookService(string connectionString) :base(connectionString)
        {

        }


        public List<Book> GetAll()
        {
          return  _unitOfWork.Books.GetAll().ToList();
        }
        public Book Get(int id)
        {
            return _unitOfWork.Books.Get(id);
        }
        public void Update(Book book)
        {
            _unitOfWork.Books.Update(book);
            _unitOfWork.Commit();
        }
        public void Create(Book book)
        {
            _unitOfWork.Books.Create(book);
            _unitOfWork.Commit();
        }
        public void Delete(int id)
        {
            _unitOfWork.Books.Delete(id);
            _unitOfWork.Commit();
        }
    }
}
