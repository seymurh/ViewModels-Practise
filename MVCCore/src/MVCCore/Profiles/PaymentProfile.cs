using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MVCCore.DomainModels;
using MVCCore.ViewModels;

namespace MVCCore.Profiles
{
    public class PaymentProfile:Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, PaymentViewModelBase>().ConvertUsing(payment => ConvertPayment(payment));
        }

        private PaymentViewModelBase ConvertPayment(Payment payment)
        {
            if (payment.PaymentType == PaymentType.CashPayment)
            {
                return new CashPaymentViewModel
                {
                    Id = payment.Id,
                    Amount = payment.Amount,
                    Branch = payment.Branch
                };
            }else if (payment.PaymentType == PaymentType.BankPayment)
            {
                return new BankPaymentViewModel
                {
                    Id = payment.Id,
                    Amount = payment.Amount,
                    AccountNumber = payment.AccountNumber
                };
            }
            else
            {
                return null;
            }
        }
    }
}
