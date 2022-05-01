using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Advisor6.Data;
using System.ComponentModel.DataAnnotations.Schema;



namespace Advisor6.Models
{
    public class Personal
    {
        [Key]
        public int PersonalId { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public MarriedStatus MarriedStatus { get; set; }
        
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string BornPlace { get; set; }
        public string Nots { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string DataEntryName { get; set; }
        public string Image { get; set; }
        public string PDF { get; set; }


        //    //Relationships
           public List<Administrative_Orders> Administrative_Orders { get; set; }

        //    //Employment_info
        //   // public int Employment_infoId { get; set; }

        //   //// [ForeignKey("Employment_infoId")]
        //   // public Employment_info Employment_info { get; set; }
    }
}
