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
                users = context.TblUsers.ToList();
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
                context.TblUsers.Add(user);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
