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
    public class PersonalService : EntityBaseRepository<Personal>, IPersonalService
    {
        private readonly AppDbContext _context;
        public PersonalService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewPersonalAsync(NewPersonalVM data)
        {
            var newPersonal = new Personal()
            {
                FullName = data.FullName,
                PhoneNo = data.PhoneNo,
                Gender = data.Gender,
                MarriedStatus = data.MarriedStatus,
                Email = data.Email,
                Address = data.Address,
                BirthDate = data.BirthDate,
                BornPlace = data.BornPlace,
                Nots = data.Nots,
                EntryDate = data.EntryDate,
                LastUpdateDate = data.LastUpdateDate,
                DataEntryName = data.DataEntryName,
                Image = data.Image,
                PDF = data.PDF,
                //Employment_infoId = data.Employment_infoId,
                //Academic_CertId = data.Academic_CertId,
                //VacationsId = data.VacationsId
            };
            await _context.Personal.AddAsync(newPersonal);
            await _context.SaveChangesAsync();
        }

        public async Task<NewPersonalDropdownsVM> GetNewPersonalDropdownsValues()
        {
            var response = new NewPersonalDropdownsVM()
            {
                Employment_infos = await _context.Employment_info.OrderBy(n => n.MainDeptartment).ToListAsync(),
                Academic_Certs = await _context.Academic_Cert.OrderBy(n => n.Academic_Degree).ToListAsync(),
                Vacationss = await _context.Vacations.OrderBy(n => n.Vacation_Start_Date).ToListAsync()

                //Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task<Personal> GetPersonalByIdAsync(int id)
        {
            var personalDetails = await _context.Personal.FirstOrDefaultAsync(n => n.Id == id);
            //    .Include(c => c.Employment_info)
            //.Include(p => p.Academic_Cert)
            //.Include(p => p.Vacations)
            //.FirstOrDefaultAsync(n => n.Id == id);
            //.Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
            // .Include(w => w.Ifad)
            //.Include(x => x.Thanks)
            //.Include(y => y.Traning)
            //.Include(z => z.Vacations)

            return personalDetails;
        }

        public async Task UpdatePersonalAsync(NewPersonalVM data)
        {
            var dbPersonal = await _context.Personal.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbPersonal != null)
            {
                dbPersonal.FullName = data.FullName;
                dbPersonal.PhoneNo = data.PhoneNo;
                dbPersonal.Gender = data.Gender;
                dbPersonal.MarriedStatus = data.MarriedStatus;
                dbPersonal.Email = data.Email;
                dbPersonal.Address = data.Address;
                dbPersonal.BirthDate = data.BirthDate;
                dbPersonal.BornPlace = data.BornPlace;
                dbPersonal.Nots = data.Nots;
                dbPersonal.EntryDate = data.EntryDate;
                dbPersonal.LastUpdateDate = data.LastUpdateDate;
                dbPersonal.DataEntryName = data.DataEntryName;
                dbPersonal.Image = data.Image;
                dbPersonal.PDF = data.PDF;
                //dbPersonal.Employment_infoId = data.Employment_infoId;
                await _context.SaveChangesAsync();
            }


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
