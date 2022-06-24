using Advisor6.Data;
using Advisor6.Data.Services;
using Advisor6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class Test : Controller
    {

        private readonly IPersonalService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Test(IPersonalService service, IWebHostEnvironment webHostEnvironment)
        {
            _service = service;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
           // var data = await _service.GetAllAsync(n => n.Employment_info);
            var data = await _service.GetAllAsync();
          
            var personalDropdownsData = await _service.GetNewPersonalDropdownsValues();
            ViewBag.Employment_infos = new SelectList(personalDropdownsData.Employment_infos, "Id", "MainDeptartment").SelectedValue;
            
            return View(data);
        }
    }

}






