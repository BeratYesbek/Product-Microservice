using Business.Abstracts;
using Core.Utilities.Abstracts;
using Core.Utilities.Concretes;
using DataAccess.Abstracts;
using Entities.Modals;

namespace Business.Concretes
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IDataResult<Color> Create(Color entity)
        {
            var color = _colorDal.Create(entity);
            if (color != null)
            {
                return new SuccessDataResult<Color>(color);
            }
            return new ErrorDataResult<Color>(color!);
        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessDataResult<Color>(entity);  
        }

        public IResult Delete(int id)
        {
            var color = _colorDal.Get(t => t.Id == id);
            if (color != null)
            {
                _colorDal.Delete(color);
                return new SuccessResult();
            }
            return new ErrorResult($"Color ID {id} not found");
        }

        public IDataResult<Color> Get(int id)
        {
            var data = _colorDal.Get(t => t.Id == id);
            if (data != null)
            {
                return new SuccessDataResult<Color>(data);
            }
            return new ErrorDataResult<Color>(data);
        }

        public IDataResult<List<Color>> GetAll()
        {
            var data = _colorDal.GetAll();
            if (data?.Count > 0)
            {
                return new SuccessDataResult<List<Color>>(data);
            }
            return new ErrorDataResult<List<Color>>(data!);
        }
    }
}
