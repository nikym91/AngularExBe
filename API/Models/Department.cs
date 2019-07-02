using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Manager { get; set; }
        public decimal Budget { get; set; }
        public bool IsTechnologic { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {

        }

        public Department(int departmentId, string name, DateTime foundationDate, string manager, decimal budget, bool isTechnologic)
        {
            DepartmentId = departmentId;
            Name = name;
            FoundationDate = foundationDate;
            Manager = manager;
            Budget = budget;
            IsTechnologic = isTechnologic;
        }
    }
}
