using Advisor6.Data.Base;
using Advisor6.Models;

namespace Advisor6.Data.Services
{
    public class Employment_infoService : EntityBaseRepository<Employment_info> , IEmployment_infoService
    {
        public Employment_infoService(AppDbContext context) : base(context)  
        {

        }
    }
}
