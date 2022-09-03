using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Core.Utilities.Abstracts;
using Entities.Modals;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        public IDataResult<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
