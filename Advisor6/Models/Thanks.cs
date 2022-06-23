using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Models
{
    public class Thanks
    {
        [Key]
        public int Id { get; set; }
        public string Thanks_Type { get; set; }
        public string Thanks_Days { get; set; }
        public string OrderType { get; set; }
        public string ThanksBook_No { get; set; }
        public string ThanksBook_Date { get; set; }
        public string Thanks_Reason { get; set; }
        public string Thanks_Sid { get; set; }
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string PID { get; set; }
        public string U_id { get; set; }   
        public string thanks_upper { get; set; }
        public string book_no { get; set; }
       
        public DateTime Inserting_Date { get; set; }
        public List<Personal> Personal { get; set; }

    }
}
