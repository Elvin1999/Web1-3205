using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Employee
    {
        [Range(1,20)]
        public int Id { get; set; }
        [DisplayName("E Name")]
        [Required()]
        public string Firstname { get; set; }
        [Required()]
        [DisplayName("E Surname")]
        public string Lastname { get; set; }
        public int CityId { get; set; }
    }
}
