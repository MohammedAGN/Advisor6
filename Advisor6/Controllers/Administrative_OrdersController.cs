using Advisor6.Data;
using Advisor6.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class Administrative_OrdersController : Controller
    {
        private readonly IAdministrative_OrdersService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Administrative_OrdersController(IAdministrative_OrdersService service, IWebHostEnvironment webHostEnvironment)
        {

            _service = service;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }
    }
}
