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

    public class Ifad : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Ifad_Type { get; set; }
        public string Ifad_Supject { get; set; }
        public string Ifad_Title { get; set; }
        public string Ifad_Sid { get; set; }
        public string Ifad_Paid_Sid { get; set; }
        public string Ifad_TravelDate { get; set; }
        public string Ifad_Days { get; set; }
        public string Title { get; set; }
        public string IfadActual_Days { get; set; }
        public string IfadDirectDate { get; set; }
        public string IfadBookNo { get; set; }
        public string IfadBookDate { get; set; }
        public string Note { get; set; }
        public string InsertingDate { get; set; }
        public string U_id { get; set; }
        public string PID { get; set; }
        public string PDF { get; set; }
        public DateTime Inserting_Date { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile pdf { get; set; }


        //Relationships
        //  public List<Personal> Personal { get; set; }

        //Personal

        [ForeignKey("PersonalId")]
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

    }
}
