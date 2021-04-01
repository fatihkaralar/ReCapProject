using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //If Bussiness Conditions Happens,here works.
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(),Messages.CarsListed);


        }

        public IDataResult<Car> GetById(int carId)
        {
           return new SuccessDataResult<Car>(_iCarDal.GetById(c=>c.Id==carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_iCarDal.GetCarDetails(),Messages.CarDetailsListed);
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new SuccessResult();
        }
    }
}
