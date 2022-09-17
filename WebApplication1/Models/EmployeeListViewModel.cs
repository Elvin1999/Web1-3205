using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}
