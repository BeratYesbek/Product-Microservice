using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Core.Utilities.Abstracts;
using Core.Utilities.Cloud.AwsService;
using Core.Utilities.Cloud.Entities;
using Core.Utilities.Concretes;
using DataAccess.Abstracts;
using Entities.Modals;
using Microsoft.AspNetCore.Http;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IS3AwsService _s3;
        private readonly IProductImageService _imageService;
        public ProductManager(IProductDal productDal, IS3AwsService s3, IProductImageService imageService)
        {
            _productDal = productDal;
            _s3 = s3;
            _imageService = imageService;
        }
        public IDataResult<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Product>> CreateAsync(Product product, IFormFile[] files)
        {
            var addedProduct = _productDal.Create(product);
            foreach (var file in files)
            {
                var result = await _s3.UploadAsync(new S3File { File = file, FileName = file.FileName });
                if (result.Success)
                {
                    _imageService.Create(new ProductImage
                    {
                        ProductId = addedProduct.Id,
                        Url = result.Data?.Url
                    });
                }
            }
            return new SuccessDataResult<Product>(addedProduct);
        }

        public IResult Update(Product entity)
        {
           
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
