using Advisor6.Data.Base;
using Advisor6.Data.ViewModels;
using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public interface IAdministrative_OrdersService :  IEntityBaseRepository<Administrative_Orders>
         
    {
        
            Task<NewPersonalDropdownsVM> GetNewPersonalDropdownsValues();
        

        
    }
}
