﻿using Advisor6.Data.Base;
using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Services
{
    public class IfadService : EntityBaseRepository<Ifad>, IIfadService
    {
        public IfadService(AppDbContext context) : base(context)
        {

        }
    
    }
}
