using Advisor6.Data;
using Advisor6.Data.Services;
using Advisor6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PersonalController(IPersonalService service, IWebHostEnvironment webHostEnvironment)
        {
            _service = service;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var data = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = data.Where(n => n.FullName.ToLower().Contains(searchString.ToLower())
                || n.Email.ToLower().Contains(searchString.ToLower())).ToList();
                //في حالة البحث مطابق للاحرف
                //var filteredResultNew = data.Where(n => string.Equals(n.FullName, searchString, StringComparison.CurrentCultureIgnoreCase) 
                //|| string.Equals(n.Email, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index1", filteredResult);
            }

            return View("Index1", data);
        }

        public async Task<IActionResult> Index1()
        {
            var data = await _service.GetAllAsync();
            //   Personal.Include(n => n.Employment_info).ToListAsync();
            return View(data);
        }

        // Get : Personal/Create
        public IActionResult CreatePersonal()
        {
            return View();
        }

        // Post : Personal/Create
        [HttpPost]
        public async Task<IActionResult> CreatePersonal(Personal personal)
        //[Bind("FullName,Gender,MarriedStatus,PhoneNo,Email,Address,BirthDate" +",BornPlace,Nots,EntryDate,DataEntryName,Image")]
        {
            if (ModelState.IsValid)
            {
                if (personal.Photo != null)
                {
                    string folder = "PADV/Photo/";

                    personal.Image = await UploadImage(folder, personal.Photo);
                }
                //await _service.AddAsync(personal);
                //     return View(personal);

                if (personal.pdf != null)
                {
                    string folder = "PADV/PDF/";

                    personal.PDF = await UploadImage(folder, personal.pdf);
                }
            }
            await _service.AddAsync(personal);
            return RedirectToAction(nameof(Index));

        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }



        //Get: Personal/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);

            if (personalDetails == null) return View("NotFound");
            return View(personalDetails);
        }

        // Get : Personal/Edit
        public async Task<IActionResult> EditPersonal(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);

            if (personalDetails == null) return View("NotFound");

            return View(personalDetails);
        }

        // Post : Personal/Edit
        [HttpPost]
        public async Task<IActionResult> EditPersonal(int id, [Bind("PersonalId,FullName,Gender,MarriedStatus,PhoneNo,Email,Address,BirthDate" +
            ",BornPlace,Nots,EntryDate,DataEntryName,Image")] Personal personal)
        {
            //var PersonalId = id;
            if (!ModelState.IsValid)
            {
                return View(personal);
            }
            await _service.UpdateAsync(id, personal);
            return RedirectToAction(nameof(Index));
        }

        // Get : Personal/Delete
        public async Task<IActionResult> DeletePersonal(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);
            if (personalDetails == null) return View("NotFound");
            return View(personalDetails);
        }

        // Post : Personal/Edit
        [HttpPost, ActionName("DeletePersonal")]
        public async Task<IActionResult> DeletePersonalConfirmed(int id)
        {
            var personalDetails = await _service.GetByIdAsync(id);

            if (personalDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        

    }
}
