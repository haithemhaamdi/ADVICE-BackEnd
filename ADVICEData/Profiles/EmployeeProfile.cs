using AutoMapper;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ADVICEDto.DTO;

namespace ADVICEData.Profiles
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
