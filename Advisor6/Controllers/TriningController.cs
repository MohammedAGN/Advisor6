using Advisor6.Data;
using Advisor6.Data.Services;
using Advisor6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class TriningController : Controller
    {
        private readonly ITriningService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TriningController(ITriningService service, IWebHostEnvironment webHostEnvironment)
        {

            _service = service;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Personal);

            return View(data);
        }
        //GET: Employment_info/create
        public async Task<IActionResult> Create()
        {
            var personalDropdownsData = await _service.GetNewPersonalDropdownsValues();

            ViewBag.Personals = new SelectList(personalDropdownsData.Personals, "Id", "FullName");

            //ViewBag.Academic_Certs = new SelectList(personalDropdownsData.Academic_Certs, "Id", "Academic_Degree");
            //ViewBag.Vacationss = new SelectList(personalDropdownsData.Vacationss, "Id", "Vacation_Start_Date");

            return View();
        }

        // Post : Employment_info/Create
        [HttpPost]
        public async Task<IActionResult> Create(Trining trining)
        //[Bind("FullName,Gender,MarriedStatus,PhoneNo,Email,Address,BirthDate" +",BornPlace,Nots,EntryDate,DataEntryName,Image")]
        {
            if (ModelState.IsValid)
            {
                //if (personal.Photo != null)
                //{
                //    string folder = "PADV/Photo/";

                //    personal.Image = await UploadImage(folder, personal.Photo);
                //}
                //await _service.AddAsync(personal);
                //     return View(personal);

                if (trining.pdf != null)
                {
                    string folder = "PADV/PDF/";

                    trining.PDF = await UploadImage(folder, trining.pdf);
                }
            }
            await _service.AddAsync(trining);
            return RedirectToAction(nameof(Index));

        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }
    }
}
