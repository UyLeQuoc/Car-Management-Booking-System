using BusinessObjects;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                    RoleId = adRole,
                    Address = ""
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
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public List<TblUser> GetAllUsersWithAdmin()
        {
            List<TblUser> users = null;
            try
            {
                var context = new CarBookingManagementContext();
                users = context.TblUsers.Where(x => x.IsDeleted == 0).ToList();
                users = users.Prepend(GetAdminAccount()).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public List<TblUser> SearchUserByName(string name)
        {
            List<TblUser> users = GetAllUsers();

            users.Where(user => user.FullName.ToLower().Contains(name.ToLower())).ToList();

            return users;
        }

        public List<TblUser> SearchUserById(int id)
        {
            List<TblUser> users = GetAllUsers();
            List<TblUser> result = new List<TblUser>();
            TblUser u = users.SingleOrDefault(user => user.UserId == id);
            if (u != null)
            {
                result.Add(u);
            }
            else
            {
                throw new Exception("Not Found!");
            }
            return result;
        }


        public TblUser checkLogin(string email, string password)
        {
            TblUser user = null;
            try
            {
                var context = GetAllUsersWithAdmin();
                user = context.SingleOrDefault(us => us.Email.Equals(email) && us.Password.Equals(password));
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

        public void Delete(string userId)
        {
            if (userId.Length == 0)
            {
                throw new Exception("User is undefined!!");
            }
            try
            {
                TblUser user = GetUser(int.Parse(userId));

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

        public TblUser GetUser(int userId)

        {
            TblUser tblUser = null;

            try
            {
                var context = GetAllUsers();
                tblUser = context.SingleOrDefault(user => user.UserId == userId);

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
