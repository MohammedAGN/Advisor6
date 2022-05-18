using Advisor6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class PersonalService : IPersonalService
    {
        private readonly AppDbContext _context;
        public PersonalService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Personal personal)
        {
          await  _context.Personal.AddAsync(personal);
          await  _context.SaveChangesAsync();
        }

        public void Delete(int id) 
        {
            throw new NotImplementedException();
        }

        public async Task< IEnumerable<Personal>> GetAllAsync()
        {
            var result = await _context.Personal.ToListAsync();

            return result;
        }

        public async Task<Personal> GetByIdAsync(int id)
        {
            var result = await _context.Personal.FirstOrDefaultAsync(n => n.PersonalId == id);
            return result;
        }

        public async Task<Personal> UpdateAsync(int id, Personal newPersonal)
        {
            _context.Update(newPersonal);
            await _context.SaveChangesAsync();
            return newPersonal;
        }
    }
}
