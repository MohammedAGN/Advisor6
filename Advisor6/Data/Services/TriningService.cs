using Advisor6.Data.Base;
using Advisor6.Data.ViewModels;
using Advisor6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class TriningService : EntityBaseRepository<Trining>, ITriningService
    {
        private readonly AppDbContext _context;

        public TriningService(AppDbContext context) : base(context)
        {

            _context = context;
        }
        public async Task<NewPersonalDropdownsVM> GetNewPersonalDropdownsValues()
        {
            var response = new NewPersonalDropdownsVM()
            {
                Personals = await _context.Personal.OrderBy(n => n.FullName).ToListAsync()

                //Academic_Certs = await _context.Academic_Cert.OrderBy(n => n.Academic_Degree).ToListAsync(),
                //Vacationss = await _context.Vacations.OrderBy(n => n.Vacation_Start_Date).ToListAsync()

                //Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }
    }
}
