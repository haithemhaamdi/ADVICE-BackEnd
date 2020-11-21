using AutoMapper;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.DTO;

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.Profiles
{
    public class BulletinPaieProfile : Profile
    {
        public BulletinPaieProfile()
        {
            CreateMap<BULLETIN_PAIE, BULLETIN_PAIEdto>();
                //.ForMember(dest =>
                //dest.Adresse,
                //opt => opt.MapFrom(src => $"{src.Adresse} {src.Ville} {src.CodePostal}"));
        }
    }
}
