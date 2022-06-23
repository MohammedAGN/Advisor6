using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Models
{
    public class Academic_Cert
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
        public List<Personal> Personal { get; set; }
    }
}
