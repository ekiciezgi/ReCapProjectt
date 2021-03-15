using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
    }
}
