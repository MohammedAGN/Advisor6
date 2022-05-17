using Advisor6.Data;
using Advisor6.Data.Services;
using Advisor6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _service;

        public PersonalController(IPersonalService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //public async Task<IActionResult> Index1()
        //{
        //    var data = await _context.Personal.Include(n=> n.Employment_info).ToListAsync();
        //    return View(data);
        //}

        // Get : Personal/Create
        public IActionResult CreatePersonal()
        {
            
            return View();
        }

        // Post : Personal/Create
        [HttpPost]
        public async Task<IActionResult> CreatePersonal([Bind("FullName,Gender,MarriedStatus,PhoneNo,Email,Address,BirthDate" +
            ",BornPlace,Nots,EntryDate,DataEntryName,Image")] Personal personal)
        {
            if (!ModelState.IsValid)
            {
                return View(personal);
            }
            _service.Add(personal);
            return RedirectToAction(nameof(Index));
        }
    }
}
