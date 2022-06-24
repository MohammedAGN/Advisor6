using Advisor6.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class IfadController : Controller
    {
        private readonly IIfadService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public IfadController(IIfadService service, IWebHostEnvironment webHostEnvironment)
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
