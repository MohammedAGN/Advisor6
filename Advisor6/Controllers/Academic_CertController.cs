using Advisor6.Data;
using Advisor6.Data.Services;
using Advisor6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class Academic_CertController : Controller
    {
        private readonly IAcademic_CertService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Academic_CertController(IAcademic_CertService service, IWebHostEnvironment webHostEnvironment)
        {

            _service = service;
            _webHostEnvironment = webHostEnvironment;
        }

        
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }
        //GET: Employment_info/create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        // Post : Employment_info/Create
        [HttpPost]
        public async Task<IActionResult> Create(Academic_Cert academic_Cert)
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

                if (academic_Cert.pdf != null)
                {
                    string folder = "PADV/PDF/";

                    academic_Cert.PDF = await UploadImage(folder, academic_Cert.pdf);
                }
            }
            await _service.AddAsync(academic_Cert);
            return RedirectToAction(nameof(Index));

        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }


        ////Get: Cinemas/Create
        //public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        //    {
        //        if (!ModelState.IsValid) return View(cinema);
        //        await _service.AddAsync(cinema);
        //        return RedirectToAction(nameof(Index));
        //    }

        //    //Get: Cinemas/Details/1
        //    [AllowAnonymous]
        //    public async Task<IActionResult> Details(int id)
        //    {
        //        var cinemaDetails = await _service.GetByIdAsync(id);
        //        if (cinemaDetails == null) return View("NotFound");
        //        return View(cinemaDetails);
        //    }

        //    //Get: Cinemas/Edit/1
        //    public async Task<IActionResult> Edit(int id)
        //    {
        //        var cinemaDetails = await _service.GetByIdAsync(id);
        //        if (cinemaDetails == null) return View("NotFound");
        //        return View(cinemaDetails);
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        //    {
        //        if (!ModelState.IsValid) return View(cinema);
        //        await _service.UpdateAsync(id, cinema);
        //        return RedirectToAction(nameof(Index));
        //    }

        //    //Get: Cinemas/Delete/1
        //    public async Task<IActionResult> Delete(int id)
        //    {
        //        var cinemaDetails = await _service.GetByIdAsync(id);
        //        if (cinemaDetails == null) return View("NotFound");
        //        return View(cinemaDetails);
        //    }

        //    [HttpPost, ActionName("Delete")]
        //    public async Task<IActionResult> DeleteConfirm(int id)
        //    {
        //        var cinemaDetails = await _service.GetByIdAsync(id);
        //        if (cinemaDetails == null) return View("NotFound");

        //        await _service.DeleteAsync(id);
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
    }
}