using Advisor6.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class Administrative_OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public Administrative_OrdersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Administrative_Orders.ToListAsync();
            return View();
        }
    }
}
