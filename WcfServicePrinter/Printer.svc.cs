using BLL;
using DAL;
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
        public void AddAmountByUserId(int userId, int amount)
        {
            IUserDb userDb = new UserDb();
            IUserManager userManager = new UserManager(userDb);
            userManager.AddAmountByUserId(userId, amount);
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
