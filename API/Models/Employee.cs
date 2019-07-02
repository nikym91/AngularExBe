using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }

        public Employee()
        {

        }

        public Employee(int employeeId, int departmentId, string firstName, string lastName, DateTime dateOfBirth, string email, string address)
        {
            EmployeeId = employeeId;
            DepartmentId = departmentId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
        }
    }
}
