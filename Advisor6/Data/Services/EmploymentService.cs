using Advisor6.Data.Base;
using Advisor6.Models;

namespace Advisor6.Data.Services
{
    public class EmploymentService : EntityBaseRepository<Employment_info> , IEmploymentService
    {
        public EmploymentService(AppDbContext context) : base(context)  
        {

        }
    }
}
