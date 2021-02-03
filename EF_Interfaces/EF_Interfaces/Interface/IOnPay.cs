using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Interfaces.Interface
{
    interface IOnPay
    {
        double PaymentFee (double amonut);
        double Interest (double amount, int months);
    }
}
