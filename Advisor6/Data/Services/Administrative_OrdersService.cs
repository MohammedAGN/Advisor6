using Advisor6.Data.Base;
using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class Administrative_OrdersService : EntityBaseRepository<Administrative_Orders>, IAdministrative_OrdersService
    {
        public Administrative_OrdersService(AppDbContext context) : base(context)
        {

        }
    }
 
}
