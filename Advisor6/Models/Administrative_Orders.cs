using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Models
{
    public class Administrative_Orders
    {
        [Key]
        public string Admi_id { get; set; }
        public int AdministrativeNo { get; set; }
        public int OrderNo { get; set; }
        public DateTime Administrative_Order_Date { get; set; }
        public string Type_Of_Order { get; set; }
        public string Subject { get; set; }
        public string Summary { get; set; }
        public string Nots { get; set; }
       
        public string Image { get; set; }
        public string PDF { get; set; }
    }
}
