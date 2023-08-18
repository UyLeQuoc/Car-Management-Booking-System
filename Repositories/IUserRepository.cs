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

        public List<TblUser> GetAllUsers();

        public void UpdateAUser(TblUser user);

        public void DeleteAUser(TblUser user);

        public TblUser GetAUser(string id);

        public TblUser GetAUser(int id);

        public List<TblUser> SearchUserByName(string name);

        public List<TblUser> SearchUserById(int id);

    }
}
