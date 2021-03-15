using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
   public  interface ICarImageService
    {
        IDataResult<List<ICarImageService>> GetAll();
        IDataResult<ICarImageService> GetById(int brandId);
        IResult Add(CarImage image);
        IResult Update(CarImage image);
        IResult Delete(CarImage image);
    }
}
