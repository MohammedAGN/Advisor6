using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Models
{
    public class Trining
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
        public string Not { get; set; }
        public DateTime Inserting_Date { get; set; }
        public List<Personal> Personal { get; set; }

    }
}
