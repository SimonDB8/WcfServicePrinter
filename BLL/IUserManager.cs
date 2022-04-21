﻿using DTO;
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

        void AddAmountByUserId(int userId, int amount);
    }

   
}
