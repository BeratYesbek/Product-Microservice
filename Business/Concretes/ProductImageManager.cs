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
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _imageDal;
        public ProductImageManager(IProductImageDal imageDal)
        {
            _imageDal = imageDal;
        }
        public IDataResult<ProductImage> Create(ProductImage entity)
        {
            return new SuccessDataResult<ProductImage>(_imageDal.Create(entity));
        }

        public IResult Update(ProductImage entity)
        {
            _imageDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var image = _imageDal.Get(t => t.Id == id);
            if (image != null)
            {
                _imageDal.Delete(image);
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IDataResult<ProductImage> Get(int id)
        {
            return new SuccessDataResult<ProductImage>(_imageDal.Get(t => t.Id == id)!);
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_imageDal.GetAll()!);
        }

        public IDataResult<List<ProductImage>> GetAllByProductId(int productId)
        {
            var data = _imageDal.GetAll(t => t.ProductId == productId);
            if (data?.Count > 0)
            {
                return new SuccessDataResult<List<ProductImage>>(data);
            }

            return new ErrorDataResult<List<ProductImage>>(data, "Not Found");
        }
    }
}
