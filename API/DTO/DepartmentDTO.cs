using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Manager { get; set; }
        public decimal Budget { get; set; }
        public bool IsTechnologic { get; set; }
    }
}
