using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstracts;
using Entities.Modals;
using Microsoft.AspNetCore.Http;

namespace Business.Abstracts
{
    public interface IProductService : IServiceRepository<Product>
    {
        Task<IDataResult<Product>> CreateAsync(Product product, IFormFile[] files);

    }
}
