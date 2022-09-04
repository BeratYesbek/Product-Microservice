using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Core.Utilities.Abstracts;
using Core.Utilities.Concretes;
using DataAccess.Abstracts;
using Entities.Modals;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<Category> Create(Category entity)
        {
            var data = _categoryDal.Create(entity);
            if (data != null)
            {
                return new SuccessDataResult<Category>(data);
            }
            return new ErrorDataResult<Category>(data!);
        }

        public IResult Update(Category entity)
        {
            _categoryDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var category = _categoryDal.Get(t => t.Id == id);
            if (category != null)
            {
                _categoryDal.Delete(category);
                return new SuccessResult("");
            }
            return new ErrorResult("");
        }

        public IDataResult<Category> Get(int id)
        {
            var category = _categoryDal.Get(t => t.Id == id);
            if (category != null)
            {
                return new SuccessDataResult<Category>(category);
            }
            return new ErrorDataResult<Category>(category!);
        }

        public IDataResult<List<Category>> GetAll()
        {
            var categories = _categoryDal.GetAll();
            if (categories?.Count > 0)
            {
                return new SuccessDataResult<List<Category>>(categories);
            }

            return new ErrorDataResult<List<Category>>(categories!);
        }
    }
}
