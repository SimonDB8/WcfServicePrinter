using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUserDb
    {
        User GetAmountByUserId(int userId);

       User AddAmountByUserId(int userId, int amount);

        User getUserById(int userId);

        User getUserByUsername(string username);

        User AddAmountByUsername(string username, int amount);

        User getAmountByUsername(string username);
    }
}
