using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstracts;

namespace Business.Abstracts
{
    public interface IServiceRepository<T>
    {
        IDataResult<T> Create(T entity);
        IResult Update(T entity);
        IResult Delete(int id);
        IDataResult<T> Get(int id);
        IDataResult<List<T>> GetAll();
    }
}
