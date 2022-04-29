using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Advisor6.Data;

namespace Advisor6.Models
{
    public class Personal
    {
        [Key]
        public string P_id { get; set; }
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
        


    }
}
