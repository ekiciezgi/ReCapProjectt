using Business.Abstarct;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carimageDal;

        public CarImageManager(ICarImageDal carimageDal)
        {
            _carimageDal = carimageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage image)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimit(image.Id));
            if (result != null)
            {
                return result;
            }
          
            return new SuccessResult();
        }

        public IResult Delete(CarImage image)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ICarImageService>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ICarImageService> GetBrandById(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ICarImageService> GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage image)
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfImageLimit(int id)
        {
            var carImagecount = _carimageDal.GetAll(c => c.Id == id).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.ImageLimitLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
