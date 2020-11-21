using AutoMapper;
using ADVICEDto.DTO;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEData.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<ROLE, ROLEdto>();
        }
    }
}
