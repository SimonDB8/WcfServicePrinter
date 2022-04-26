﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePrinter
{
    [ServiceContract]
    public interface IPrinter
    {
        [OperationContract]
        int GetAmountByUserId(int userId);

        [OperationContract]
        User AddAmountByUserId(int userId, int amount);

        [OperationContract]
        User AddAmountByUsername(string username, int amount);
    }
}
