using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _iUserDal;
        public UserManager(IUserDal iUserDal)
        {
            _iUserDal = iUserDal;
        }

        public IResult Add(User user)
        {
            _iUserDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _iUserDal.Delete(user);
            return new SuccessResult();

        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_iUserDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_iUserDal.GetById(u => u.Id == userId));
        }

        public IResult Update(User user)
        {
            _iUserDal.Update(user);
            return new SuccessResult();
        }
    }
}
