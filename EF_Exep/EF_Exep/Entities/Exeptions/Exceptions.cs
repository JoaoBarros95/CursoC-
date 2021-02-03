using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Exep.Entities.Exeptions
{
    class Exceptions : ApplicationException
    {
        public Exceptions(string message) : base(message)
        {

        }
    }
}
