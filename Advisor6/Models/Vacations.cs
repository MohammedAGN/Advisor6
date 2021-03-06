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
    public class Vacations : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Payment_Type { get; set; }
        public string Vacation_Start_Date { get; set; }
        public string Vacation_End_Date { get; set; }
        public string Vacation_Days { get; set; }
        public string Emp_Vacations_Total { get; set; }
        public string Sick_Vacation_Days { get; set; }
        public string Emp_Vacations_SickTotal { get; set; }
        public string Vacation_Book_No { get; set; }
        public string Vacation_Book_Date { get; set; }
        public string Vacation_No { get; set; }
        public string Note { get; set; }
        public string PID { get; set; }
        public string Vacation_WithOrder { get; set; }
        public string U_id { get; set; }
        public string vacation_upper { get; set; }
        public string order_no { get; set; }
        public string book_no { get; set; }
        public string Notes { get; set; }
        public string PDF { get; set; }
        public DateTime Inserting_Date { get; set; }
        
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }

        //public List<Personal> Personal { get; set; }
        [ForeignKey("PersonalId")]
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

    }
}
