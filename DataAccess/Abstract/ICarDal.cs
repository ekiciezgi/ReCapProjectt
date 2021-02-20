﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();
    }
}
