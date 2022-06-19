using Advisor6.Data.Base;
using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
   public interface IPersonalService : IEntityBaseRepository<Personal>
    {
        Task<Personal> GetPersonalByIdAsync(int id);
        // تم حذفها في المحاضرة 41
        //Task< IEnumerable<Personal>> GetAllAsync();
        //Task <Personal> GetByIdAsync(int id);
        // Task AddAsync(Personal personal);
        //Task<Personal> UpdateAsync(int id, Personal newPersonal);
        // Task DeleteAsync(int id);
    }
}
