﻿using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Advisor6.Models
{
    public class Employment_info
    {

        [Key]
        public string Employee_id { get; set; }
        public string FullName { get; set; }
        public string MainDeptartment { get; set; }
        public string SubDeptartment { get; set; }
        public string Salary { get; set; }
        public string Service_Continuation { get; set; }
        public string Job_Title { get; set; }
        public string Job_Status { get; set; }
        public string EmploymentBook_No { get; set; }
        public DateTime EmploymentBook_Date { get; set; }
        public string DirectBook_No { get; set; }
        public DateTime DirectBook_Date { get; set; }
        public string Nots { get; set; }
        public string Image { get; set; }
        public string PDF { get; set; }
    }
}