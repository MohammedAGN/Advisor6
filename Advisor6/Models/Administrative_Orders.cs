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
    public class Administrative_Orders : IEntityBase
    {
       [Key]
        public int Id { get; set; }
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


        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }


        //Relationships
        //public List<Personal> Personal { get; set; }


        //   //Relationships

        //Personal

        [ForeignKey("PersonalId")]
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

        //Employment_info

        //[ForeignKey("Employee_id")]
        //public int Employee_id { get; set; }
        //public Employment_info Employment_info { get; set; }

    }
}
