using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Advisor6.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Advisor6.Data.Base;
using Microsoft.AspNetCore.Http;

namespace Advisor6.Models
{
    public class Personal : IEntityBase
    {
        [Key]
        public int PersonalId { get; set; }

      //  [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public MarriedStatus MarriedStatus { get; set; }

       // [Display(Name = "PhoneNo")]
        public string PhoneNo { get; set; }

       // [Display(Name = "Email")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string BornPlace { get; set; }

      //  [Display(Name = "Nots")]
        public string Nots { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string DataEntryName { get; set; }

       // [Display(Name = "Image")]
        public string Image { get; set; }

       // [Display(Name = "PDF")]
        public string PDF { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }


        //    //Relationships
        public List<Administrative_Orders> Administrative_Orders { get; set; }

        //    //Employment_info
        //   // public int Employment_infoId { get; set; }

        //   //// [ForeignKey("Employment_infoId")]
        public Employment_info Employment_info { get; set; }
    }
}
