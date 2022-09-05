using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Abstracts;
using Core.Utilities.Cloud.Entities;

namespace Core.Utilities.Cloud.CloudRepository
{
    public interface ICloudAsyncRepository<T> where T : CloudFile,new()
    {
        Task<IDataResult<T>> UploadAsync(T cloudEntity);
    }
}
