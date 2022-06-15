using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Models
{
    public class test
    {
        [Key]
        public int testId { get; set; }
        public int test1 { get; set; }
        public int test2 { get; set; }
    }
}
