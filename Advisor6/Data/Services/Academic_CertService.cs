using Advisor6.Data.Base;
using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class Academic_CertService : EntityBaseRepository<Academic_Cert>,IAcademic_CertService
    {
        public Academic_CertService(AppDbContext context) : base(context)
        {

        }
    }
}
