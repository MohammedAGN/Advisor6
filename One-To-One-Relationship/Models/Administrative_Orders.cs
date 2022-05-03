using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Advisor6.Models
{
    public class Administrative_Orders
    {
        [Key]
        public int Admi_id { get; set; }
        public int AdministrativeNo { get; set; }
        public int OrderNo { get; set; }
        public DateTime Administrative_Order_Date { get; set; }
        public string Type_Of_Order { get; set; }
        public string Subject { get; set; }
        public string Summary { get; set; }
        public string Nots { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LadtUpdateDate { get; set; }
        public string DataEntryName { get; set; }

        public string Image { get; set; }
        public string PDF { get; set; }

        //   //Relationships

       //Personal

        [ForeignKey("PersonalId")]
       public int PersonalId { get; set; }       
       public Personal Personal { get; set; }

        //Employment_info

        [ForeignKey("Employee_id")]
        public int Employee_id { get; set; }
        public Employment_info Employment_info { get; set; }

    }
}
