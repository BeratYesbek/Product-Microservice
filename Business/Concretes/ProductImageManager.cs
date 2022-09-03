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
    public class ProductImageManager : IProductImageService
    {
        public IDataResult<ProductImage> Create(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
