using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddAUser(TblUser user) => UserDAO.Instance.AddAUser(user);

        public TblUser checkLogin(string email, string password) 
            => UserDAO.Instance.checkLogin(email, password);

    }
}
