using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerococina2018.Library.DL;
using Aerococina2018.BE;
namespace Aerococina2018
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<empleados, EmpleadosBE>(MemberList.Destination)
                .ReverseMap();
        }
    }
}
