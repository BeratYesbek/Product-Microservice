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
    public class CategoryManager : ICategoryService
    {
        public IDataResult<Category> Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
