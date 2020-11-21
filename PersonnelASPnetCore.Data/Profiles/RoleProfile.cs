using AutoMapper;
using PersonnelASPnetCore.Dto.DTO;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<ROLE, ROLEdto>();
        }
    }
}
