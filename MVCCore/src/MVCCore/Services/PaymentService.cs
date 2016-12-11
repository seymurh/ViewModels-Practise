using MVCCore.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Services
{
    public class PaymentService
    {
        List<Payment> Payments = new List<Payment>()
        {
            new Payment
                {
                    Id=1,
                    PaymentType = PaymentType.CashPayment,
                    Branch="Branch1",
                    Amount = 50m
                },
            new Payment
            {
                Id=2,
                PaymentType=PaymentType.BankPayment,
                AccountNumber="123",
                Amount=33m
            }
        };

        public Payment GetPayment(int id)
        {
            return Payments.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
