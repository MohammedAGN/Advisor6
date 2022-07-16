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
    public class Academic_Cert : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Academic_Degree { get; set; }
        public string University { get; set; }
        public string College { get; set; }
        public string Department { get; set; }
        public string Specilisit { get; set; }
        public string Graduate_Year { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }
        public string PDF { get; set; }
        public DateTime Inserting_Date { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }


        //Relationships
        //public List<Personal> Personal { get; set; }
        [ForeignKey("PersonalId")]
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
    }
}
