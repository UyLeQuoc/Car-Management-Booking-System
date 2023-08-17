using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        public TblUser checkLogin(string email, string password);

        public void AddAUser(TblUser user);
    }
}
