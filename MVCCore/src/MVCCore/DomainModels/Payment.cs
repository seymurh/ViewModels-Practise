using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.DomainModels
{
    public class Payment
    {
        public PaymentType PaymentType { get; set; }
        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public decimal Amount { get; set; }

        public string Branch { get; set; }
    }
}
