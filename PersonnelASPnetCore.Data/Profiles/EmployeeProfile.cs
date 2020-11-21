using AutoMapper;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using PersonnelASPnetCore.Dto.DTO;

namespace PersonnelASPnetCore.Data.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EMPLOYE, EMPLOYEdto>()
                .ForMember(dest =>
                dest.Adresse,
                opt => opt.MapFrom(src => $"{src.Adresse} {src.Ville} {src.CodePostal}"));
        }
    }
}
