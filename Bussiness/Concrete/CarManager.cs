using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal; ;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                Console.WriteLine(car.CarName+" added successfully!");
            }
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //If Bussiness Conditions Happens,here works.
            return _iCarDal.GetAll();

        }

        public Car GetById(int carId)
        {
           return _iCarDal.GetById(c=>c.Id==carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}
