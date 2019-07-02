using API.DTO;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class ClubProfile : Profile
    {
        public ClubProfile()
        {
            this.CreateMap<Department, DepartmentDTO>()
                .ReverseMap();

            this.CreateMap<Employee, EmployeeDTO>()
                .ReverseMap();
        }
    }
}
