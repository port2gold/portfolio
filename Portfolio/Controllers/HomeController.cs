using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;


namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioRepository _portfolio;
        /// <summary>
        /// Injection of IPortfolioRepository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="port"></param>
        public HomeController(ILogger<HomeController> logger,IPortfolioRepository port)
        {
            _logger = logger;
            _portfolio = port ;
        }
        /// <summary>
        /// model of interface is injected in to the view
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IActionResult Index(int index = 1)
        {
            var model = _portfolio.GetPortfolio(index);
            
            return View(model) ;
        }

       

       
    }
}
