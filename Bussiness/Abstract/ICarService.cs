using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int carId);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);


    }
}
