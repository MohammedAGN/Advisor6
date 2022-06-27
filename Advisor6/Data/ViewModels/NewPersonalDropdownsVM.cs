using Advisor6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.ViewModels
{
    public class NewPersonalDropdownsVM
    {
        public NewPersonalDropdownsVM()
        {
            Personals = new List<Personal>();
            Employment_infos = new List<Employment_info>();
            Academic_Certs = new List<Academic_Cert>();
            Administrative_Orderss = new List<Administrative_Orders>();
            Ifads = new List<Ifad>();
            Thankss = new List<Thanks>();
            Trinings = new List<Trining>();
            Vacationss = new List<Vacations>();
            
           
        }
        public List<Personal> Personals { get; set; }
        public List<Employment_info> Employment_infos { get; set; }
        public List<Academic_Cert> Academic_Certs { get; set; }
        public List<Administrative_Orders> Administrative_Orderss { get; set; }
        public List<Ifad> Ifads { get; set; }
        public List<Thanks> Thankss { get; set; }
        public List<Trining> Trinings { get; set; }
        public List<Vacations> Vacationss { get; set; }
        
    }
}