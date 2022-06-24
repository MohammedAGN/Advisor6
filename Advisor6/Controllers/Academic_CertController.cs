using Advisor6.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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