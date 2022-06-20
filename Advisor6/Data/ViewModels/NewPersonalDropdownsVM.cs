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
            Employment_infos = new List<Employment_info>();
            //Cinemas = new List<Cinema>();
            //Actors = new List<Actor>();
        }

        public List<Employment_info> Employment_infos { get; set; }
        //public List<Cinema> Cinemas { get; set; }
        //public List<Actor> Actors { get; set; }
    }
}