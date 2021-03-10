using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            _iCarDal.Add(car);
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
           return _iCarDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}
