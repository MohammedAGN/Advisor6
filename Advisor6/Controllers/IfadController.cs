﻿using Advisor6.Data;
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
        //GET: Employment_info/create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        // Post : Employment_info/Create
        [HttpPost]
        public async Task<IActionResult> Create(Ifad ifad)
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

                if (ifad.pdf != null)
                {
                    string folder = "PADV/PDF/";

                    ifad.PDF = await UploadImage(folder, ifad.pdf);
                }
            }
            await _service.AddAsync(ifad);
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
