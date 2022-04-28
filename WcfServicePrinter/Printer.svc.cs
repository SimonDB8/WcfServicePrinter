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
             IUserDb userDb = new UserDb();
             IUserManager userManager = new UserManager(userDb);
             var user = userManager.getUserById(userId);
             userManager.AddAmountByUserId(user.userId, amount + user.userAmount);
             return userManager.getUserById(userId);
        }


        public int GetAmountByUserId(int userId)
        {
            try
            {
                IUserDb userDb = new UserDb();
                IUserManager userManager = new UserManager(userDb);
                var user = userManager.GetAmountByUserId(userId);
                return user.userAmount;
            }
            catch (Exception e)
            {
                return -1;
            }
            
        }

        public User AddAmountByUsername(string username, int amount)
        {
            IUserDb userDb = new UserDb();
            IUserManager userManager = new UserManager(userDb);
            var user = userManager.getUserByUsername(username);
            userManager.AddAmountByUserId(user.userId, amount + user.userAmount);
            return userManager.getUserByUsername(username);
        }

        public int GetAmountByUsername(string username) 
        {

            
                IUserDb userDb = new UserDb();
                IUserManager userManager = new UserManager(userDb);
                var user = userManager.getAmountByUsername(username);
            if (user!=null)
            {
                return user.userAmount;
            }
            else
            {
                return -1;
            }

                
            
                 
        }

        public int Conversion(int userId)
        {
            IUserDb userDb = new UserDb();
            IUserManager userManager = new UserManager(userDb);
            var user = userManager.GetAmountByUserId(userId);
            int nbImpression = (int)(user.userAmount/0.08);
            return nbImpression;
        }

        public int ConversionByUsername(string username)
        {
            IUserDb userDb = new UserDb();
            IUserManager userManager = new UserManager(userDb);
            var user = userManager.getAmountByUsername(username);
            if (user != null)
            {
                int nbImpression = (int)(user.userAmount / 0.08);
                return nbImpression;
            }
            else
            {
                return -1;
            }
            
        }

    }
}
