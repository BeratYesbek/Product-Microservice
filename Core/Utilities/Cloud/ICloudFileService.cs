using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Cloud.CloudRepository;
using Core.Utilities.Cloud.Entities;

namespace Core.Utilities.Cloud
{
    public interface ICloudFileService<T> :ICloudRepository<T>, ICloudAsyncRepository<T> where T : CloudFile, new()
    {

    }
}
