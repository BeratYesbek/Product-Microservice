using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Cloud.Entities;

namespace Core.Utilities.Cloud.CloudRepository
{
    public interface ICloudRepository<T> where T : CloudFile, new()
    {
        T Upload(T cloudEntity);
    }
}
