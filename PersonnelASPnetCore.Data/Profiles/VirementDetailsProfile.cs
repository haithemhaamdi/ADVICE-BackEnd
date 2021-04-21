using AutoMapper;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.VIREMENT_DETAIL_Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.Profiles
{
    public class VirementDetailsProfile : Profile
    {
        public VirementDetailsProfile()
        {
            CreateMap<VIREMENT_DETAIL, VirementDetailResponseDto>();
        }
    }
}
