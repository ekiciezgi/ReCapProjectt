using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{

    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1,ColorId=1,BrandId=1,Description="sdfghjk",ModelYear=2010,DailyPrice =20000040},
                new Car{ CarId=2,ColorId=2,BrandId=2,Description="sdfghjk",ModelYear=2013,DailyPrice =2000000},
                new Car{ CarId=3,ColorId=3,BrandId=3,Description="sdfghjk",ModelYear=2810,DailyPrice =20000003},
                new Car{ CarId=4,ColorId=4,BrandId=4,Description="sdfghjk",ModelYear=2110,DailyPrice =20000030},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            
            carToDelete=_cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        { Car carUpDate=_cars.SingleOrDefault(p => p.CarId == car.CarId);
            carUpDate.CarId = car.CarId;
            carUpDate.CarId = car.BrandId;
            carUpDate.ColorId = car.ColorId;
            carUpDate.DailyPrice = car.DailyPrice;
            carUpDate.Description = car.Description;

        }
        
       
    }
}