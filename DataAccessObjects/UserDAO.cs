using BusinessObjects;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class UserDAO
    {
        private UserDAO() { }
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object(); 
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        private TblUser GetAdminAccount()
        {
            TblUser admin = null;
            try
            {
                // lay ra tai khoan cua admin
                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
                var adEmail = config["AdminAccount:Email"];
                var adPassword = config["AdminAccount:Password"];
                var adRole = config["AdminAccount:Role"];
                admin = new TblUser()
                {
                    UserId = 0,
                    Email = adEmail,
                    FullName = adRole,
                    Password = adPassword,
                    RoleId = adRole
                };
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return admin;
        }

        public List<TblUser> GetAllUsers()
        {
            List<TblUser> users = null;
            try
            {
                var context = new CarBookingManagementContext();
                users = context.TblUsers.Where(x => x.IsDeleted == 0).ToList();
                users = users.Prepend(GetAdminAccount()).ToList();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public TblUser checkLogin(string email, string passwword)
        {
            TblUser user = null;
            try
            {
                var context = GetAllUsers();
                user = context.FirstOrDefault(us => us.Email.Equals(email) && us.Password.Equals(passwword));
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void AddAUser(TblUser user)
        {
            if (user == null)
            {
                throw new Exception("User is undefined!");
            }
            try
            {
                var context = new CarBookingManagementContext();
                // check duplicate of email
                var checkDuplicate = context.TblUsers.SingleOrDefault(us => us.Email.Equals(user.Email));
                if (checkDuplicate != null)
                {
                    throw new Exception("Email has already existed!");
                }
                context.TblUsers.Add(user);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TblUser user)
        {
            if (user == null)
            {
                throw new Exception("User is undefined!!");
            }
            try
            {
                TblUser _user = GetUser(user.UserId);
                if (_user != null)
                {
                    var context = new CarBookingManagementContext();
                    context.TblUsers.Update(_user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Delete(string userId)
        {
            if (userId.Length == 0)
            {
                throw new Exception("User is undefined!!");
            }
            try
            {
                TblUser user = GetUser(userId);
                if (user != null)
                {
                    user.IsDeleted = 1;
                    var context = new CarBookingManagementContext();
                    context.TblUsers.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private TblUser GetUser(int userId)
        {
            TblUser tblUser = null;

            try
            {
                using(var context = new CarBookingManagementContext()){
                    tblUser = context.TblUsers.SingleOrDefault(user => user.UserId == userId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("User does not exist!!");
            }

            return tblUser;
        }

        private TblUser GetUser(string userId)
        {
            TblUser tblUser = null;

            try
            {
                using (var context = new CarBookingManagementContext())
                {
                    tblUser = context.TblUsers.SingleOrDefault(user => user.UserId == int.Parse(userId));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("User does not exist!!");
            }

            return tblUser;
        }
    }
}
