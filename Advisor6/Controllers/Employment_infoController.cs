using Advisor6.Data;
using Advisor6.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class Employment_infoController : Controller
    {
        private readonly IEmploymentService _service;

        public Employment_infoController(IEmploymentService service)
        {
            _service= service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View();
        }
    }
}
