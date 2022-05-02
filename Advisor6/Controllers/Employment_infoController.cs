using Advisor6.Data;
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
        private readonly AppDbContext _context;

        public Employment_infoController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Employment_info.ToListAsync();
            return View();
        }
    }
}
