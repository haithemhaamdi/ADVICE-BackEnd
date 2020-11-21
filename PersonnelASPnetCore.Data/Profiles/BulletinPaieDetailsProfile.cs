using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using PersonnelASPnetCore.Domaine.Entities;

namespace PersonnelASPnetCore.Data.Profiles
{
    public class BulletinPaieDetailsProfile : Profile
    {
        public BulletinPaieDetailsProfile()
        {
            CreateMap<BULLETIN_PAIE_DETAIL, BULLETIN_PAIE_DETAILdto>();
        }
    }
}
