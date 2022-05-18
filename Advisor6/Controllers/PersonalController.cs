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
            var data = await _service.GetAllAsync();
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
           await _service.AddAsync(personal);
            return RedirectToAction(nameof(Index));
        }

        //Get: Personal/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);

            if (personalDetails == null) return View("NotFound");
            return View(personalDetails);
        }

        // Get : Personal/Edit
        public async Task <IActionResult> EditPersonal(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);

            if (personalDetails == null) return View("NotFound");
            return View(personalDetails);
        }

        // Post : Personal/Edit
        [HttpPost]
        public async Task<IActionResult> EditPersonal(int id,[Bind("PersonalId,FullName,Gender,MarriedStatus,PhoneNo,Email,Address,BirthDate" +
            ",BornPlace,Nots,EntryDate,DataEntryName,Image")] Personal personal)
        {
            if (!ModelState.IsValid)
            {
                return View(personal);
            }
            await _service.UpdateAsync(id, personal);

            return RedirectToAction(nameof(Index));
        }

    }
}
