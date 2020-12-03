using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        User GetUserByActivationCode(Guid guid);
        User GetUserByLoginData(string mail, string password);
    }
}
