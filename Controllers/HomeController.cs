using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdventureWorksSales.Models;
using AdventureWorksSales.Web.Services.Interfaces;

namespace AdventureWorksSales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISalesOrderService _salesOrderService;

        public HomeController(ILogger<HomeController> logger, ISalesOrderService salesOrderService)
        {
            _logger = logger;
            _salesOrderService = salesOrderService;
        }

        public IActionResult Index()
        {
            var res = _salesOrderService.GetAllSalesOrder();
            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
