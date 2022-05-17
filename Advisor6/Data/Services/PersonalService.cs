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

        public void Add(Personal personal)
        {
            _context.Personal.Add(personal);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task< IEnumerable<Personal>> GetAll()
        {
            var result = await _context.Personal.ToListAsync();

            return result;
        }

        public Personal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Personal Update(int id, Personal newPersonal)
        {
            throw new NotImplementedException();
        }
    }
}
