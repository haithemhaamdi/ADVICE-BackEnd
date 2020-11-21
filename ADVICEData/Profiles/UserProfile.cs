using AutoMapper;
using ADVICEDto.DTO;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEData.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<USER, USERdto>();
        }

    }
}
