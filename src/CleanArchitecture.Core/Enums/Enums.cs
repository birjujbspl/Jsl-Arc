﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Enums
{
    public enum ServiceStatus
    {
        Disable = 9,
        Active = 1,
        InActive = 0
    }
    public enum TransactionStatus
    {
        Success = 1,
        OperatorFail = 2 ,
        SystemFail = 3,
        Hold = 4,
        Refunded = 5,
        Pending = 6
    }
    public enum EnTrnType
    {       
        Transaction = 1,
        Buy_Trade = 4,
        Sell_Trade = 5,
        Withdraw = 6,
        Shoping_Cart = 7,
        Deposit = 8,
        Generate_Address = 9
    }
}
