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
    public class Trining : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Training_Name { get; set; }
        public string Training_PaidSid { get; set; }
        public string Training_Sid { get; set; }
        public string Training_Days { get; set; }
        public string Training_StartDate { get; set; }
        public string Training_EndDate { get; set; }
        public string Training_DirectDate { get; set; }
        public string Training_GraduteDate { get; set; }
        public string Training_Esimate { get; set; }
        public string TrainingBookNo { get; set; }
        public string TrainingBookDate { get; set; }   
        public string Vacation_WithOrder { get; set; }
        public string U_id { get; set; }
        public string PID { get; set; }
        public string T_status { get; set; }
        public string T_type { get; set; }
        public string Notes { get; set; }
        public string PDF { get; set; }
        public DateTime Inserting_Date { get; set; }
        
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }

        // public List<Personal> Personal { get; set; }
        //Personal

        [ForeignKey("PersonalId")]
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

    }
}
