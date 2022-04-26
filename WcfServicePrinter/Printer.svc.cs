using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePrinter
{
    public class Printer : IPrinter
    {
        public User AddAmountByUserId(int userId, int amount)
        {
            User u = null;

            try
            {
                IUserDb userDb = new UserDb();
                UserManager userManager = new UserManager(userDb);
                User user = userManager.getUserById(userId);
                userManager.AddAmountByUserId(user.userId, amount + user.userAmount);
                u = userManager.getUserById(userId);
            }
            catch (Exception e)
            {
                throw e;
            }

            return u;
           
        }

        public int GetAmountByUserId(int userId)
        {
            IUserDb userDb = new UserDb();
            IUserManager userManager = new UserManager(userDb);
            var user = userManager.GetAmountByUserId(userId);
            return user.userAmount;
        }
    }
}
