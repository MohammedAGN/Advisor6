using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
   public interface IPersonalService
    {
       Task< IEnumerable<Personal>> GetAll();
        Personal GetById(int id);
        void Add(Personal personal);
        Personal Update(int id, Personal newPersonal);
        void Delete(int id);
    }
}
