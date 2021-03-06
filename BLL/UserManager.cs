using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private IUserDb UserDb { get; }

        public UserManager(IUserDb userDb)
        {
            UserDb = userDb;
        }

        public User GetAmountByUserId(int userId)
        {
            return UserDb.GetAmountByUserId(userId);
        }

        public User AddAmountByUserId(int userId, int amount)
        {
            return UserDb.AddAmountByUserId(userId, amount);
        }

        public User getUserById(int userId)
        {
            return UserDb.getUserById(userId);
        }

        public User AddAmountByUsername(string username, int amount)
        {
            return UserDb.AddAmountByUsername(username, amount);
        }

        public User getUserByUsername(string username)
        {
            return UserDb.getUserByUsername(username);
        }

        public User getAmountByUsername(string username)
        {
            return UserDb.getAmountByUsername(username);
        }
    }
}
