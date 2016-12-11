using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.ViewModels
{
    public class PaymentViewModelBase
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
