using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _iRentalDal;

        public RentalManager(IRentalDal  iRentalDal)
        {
            _iRentalDal = iRentalDal;
        }
        
        
        public IResult Add(Rental rental)
        {
            
            if (_iRentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null).Count>0)
            {
                Console.WriteLine(_iRentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null).Count);
                return new ErrorResult(Messages.CarNotReturned);
               
            }
            else
            {
                _iRentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
                

            }
            
        }

        public IResult Delete(Rental rental)
        {
            _iRentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_iRentalDal.GetById(r=>r.Id==rentalId));
        }

        public IResult Update(Rental rental)
        {
            _iRentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
