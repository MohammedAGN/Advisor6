using Advisor6.Data;
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
        private readonly AppDbContext _context;

        public PersonalController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Personal.ToListAsync();
            return View(data);
        }

        public async Task<IActionResult> Index1()
        {
            var data = await _context.Personal.Include(n=> n.Employment_info).ToListAsync();
            return View(data);
        }
    }
}
