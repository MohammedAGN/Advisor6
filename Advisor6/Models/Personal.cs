using System.ComponentModel.DataAnnotations;

namespace Advisor6.Models
{
    public class Personal
    {
        [Key]
        public string P_id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string BornPlace { get; set; }
        public string Nots { get; set; }
        public string Image { get; set; }
        public string PDF { get; set; }
        


    }
}
