using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Services;
using MVCCore.DomainModels;
using AutoMapper;
using MVCCore.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCCore.Controllers
{
    public class PaymentController : Controller
    {
        PaymentService paymentService;
        IMapper mapper;
        public PaymentController(IMapper mapper)
        {
            this.mapper = mapper;
            paymentService = new PaymentService();
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            Payment payment = paymentService.GetPayment(id);
            PaymentViewModelBase viewModel = mapper.Map<PaymentViewModelBase>(payment);
            return View(viewModel);
        }
    }
}
