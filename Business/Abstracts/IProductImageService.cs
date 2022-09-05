using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstracts;
using Entities.Modals;

namespace Business.Abstracts
{
    public interface IProductImageService : IServiceRepository<ProductImage>
    {
        IDataResult<List<ProductImage>> GetAllByProductId(int productId);
    }
}
