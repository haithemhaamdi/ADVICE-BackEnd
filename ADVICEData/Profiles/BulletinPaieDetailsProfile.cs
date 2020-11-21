using ADVICEDto.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ADVICEDomaine.Entities;

namespace ADVICEData.Profiles
{
    public class BulletinPaieDetailsProfile : Profile
    {
        public BulletinPaieDetailsProfile()
        {
            CreateMap<BULLETIN_PAIE_DETAIL, BULLETIN_PAIE_DETAILdto>();
        }
    }
}
