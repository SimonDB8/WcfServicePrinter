using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUserManager
    {
        User GetAmountByUserId(int userId);

        User AddAmountByUserId(int userId, int amount);

        User getUserById(int userId);
    }

   
}
