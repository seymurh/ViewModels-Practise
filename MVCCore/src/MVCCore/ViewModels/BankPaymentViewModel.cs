using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.ViewModels
{
    public class BankPaymentViewModel:PaymentViewModelBase
    {
        public string AccountNumber { get; set; }
    }
}
