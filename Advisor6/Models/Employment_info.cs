using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;

using System.Linq;
using Advisor6.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Advisor6.Data.Base;
using Microsoft.AspNetCore.Http;

namespace Advisor6.Models
{
    public class Employment_info : IEntityBase
    {

       [Key]
        public int PersonalId { get; set; }
        public string FullName { get; set; }
        public string MainDeptartment { get; set; }
        public string SubDeptartment { get; set; }
        public string Salary { get; set; }
        public Service_Continuation Service_Continuation { get; set; }
        public string Job_Title { get; set; }
        public string Job_Status { get; set; }
        public string EmploymentBook_No { get; set; }
        public DateTime EmploymentBook_Date { get; set; }
        public string DirectBook_No { get; set; }
        public DateTime DirectBook_Date { get; set; }

        public DateTime Actual_direct_date { get; set; }
        public DateTime Contract_expiry_date { get; set; }
        public string Last_Job { get; set; }

        public string Nots { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string DataEntryName { get; set; }
        public string Image { get; set; }
        public string PDF { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }

        //  //Relationships

        //public List<Administrative_Orders> Administrative_Orders { get; set; }

        // //  //Personal
        // ////  [ForeignKey("PersonalId")]
        // public int PersonalId { get; set; }

        // public Personal Personal { get; set; }
    }
}
