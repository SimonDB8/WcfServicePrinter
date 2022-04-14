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

    }
}
