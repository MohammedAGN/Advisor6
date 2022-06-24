using Advisor6.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class VacationsController : Controller
    {
        private readonly IVacationsService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VacationsController(IVacationsService service, IWebHostEnvironment webHostEnvironment)
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
