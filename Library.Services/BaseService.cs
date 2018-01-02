using Library.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Services
{
   public abstract class BaseService
    {
        protected UnitOfWork _unitOfWork;
        public BaseService(string connectionString)
        {
            _unitOfWork = new UnitOfWork(connectionString);
        }
    }
}
