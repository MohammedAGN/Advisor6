using Advisor6.Data.Base;
using Advisor6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class PersonalService : EntityBaseRepository<Personal>, IPersonalService
    {
       // private readonly AppDbContext _context;
        public PersonalService(AppDbContext context) : base(context)
        {

        }
        // تم حذفها في المحاضرة 41
        //{
        //    _context = context;
        //}
        
        //public async Task AddAsync(Personal personal)
        //{
        //  await  _context.Personal.AddAsync(personal);
        //  await  _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id) 
        //{
        //    var result = await _context.Personal.FirstOrDefaultAsync(n => n.PersonalId == id);
        //     _context.Personal.Remove(result);
        //    await _context.SaveChangesAsync();
        //}
        //// تم كتابتها في - EntityBaseRepository
        ////public async Task< IEnumerable<Personal>> GetAllAsync()
        ////{
        ////    var result = await _context.Personal.ToListAsync();

        ////    return result;
        ////}

        ////public async Task<Personal> GetByIdAsync(int id)
        ////{
        ////    var result = await _context.Personal.FirstOrDefaultAsync(n => n.PersonalId == id);
        ////    return result;
        ////}

        //public async Task<Personal> UpdateAsync(int id, Personal newPersonal)
        //{
        //    _context.Update(newPersonal);
        //    await _context.SaveChangesAsync();
        //    return newPersonal;
        //}
    }
}
