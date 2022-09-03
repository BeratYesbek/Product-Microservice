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
    public class ColorManager : IColorService
    {
        public IDataResult<Color> Create(Color entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Color> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
