using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using PersonnelASPnetCore.Dto.USER_Dto;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.ROLE_Dto;
using PersonnelASPnetCore.Dto.BULLETIN_PAIE_Dto;
using PersonnelASPnetCore.Dto.EMPLOYE_Dto;
using PersonnelASPnetCore.Dto.DTO;
using PersonnelASPnetCore.Dto.CONNECTIONS_HISTORY_Dto;
using PersonnelASPnetCore.Dto.BULLETIN_PAIE_DETAIL_Dto;

namespace PersonnelASPnetCore.Data.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AddUserDto, USER>().ReverseMap();
            CreateMap<EditUserDto, USER>().ReverseMap();
            CreateMap<USER, UserResponseDto>().ReverseMap();
            CreateMap<RegisterUserDto, USER>();
            CreateMap<UpdateUserDto, USER>();
            CreateMap<UserTokenDto, USER>();

            CreateMap<BULLETIN_PAIE_DETAIL, BulletinPaieDetailResponseDto>().ReverseMap();


            CreateMap<AuthenticateResponseDto, USER>();
            CreateMap<AuthenticateRequestDto, USER>();
            CreateMap<RevokeTokenRequestDto, USER>();
            CreateMap<LogOutDto, USER>();
            


            CreateMap<USER, UsersDto>();

            CreateMap<USER, USERdto>();

            CreateMap<AddRoleDto, ROLE>().ReverseMap();
            CreateMap<EditRoleDto, ROLE>().ReverseMap();
            CreateMap<ROLE, RoleResponseDto>().ReverseMap();
            CreateMap<ROLE, RoleUserResponseDto>().ReverseMap();


            CreateMap<AddBulletinPaieDto, BULLETIN_PAIE>().ReverseMap();
            CreateMap<EditBulletinPaieDto, BULLETIN_PAIE>().ReverseMap();

            CreateMap<BulletinPaieResponseDto, BULLETIN_PAIE>().ReverseMap();


            CreateMap<AddEmployeDto, EMPLOYE>().ReverseMap();
            CreateMap<EditEmployeDto, EMPLOYE>().ReverseMap();
            CreateMap<EMPLOYE, EmployeResponseDto>().ReverseMap();

            CreateMap<AddConnectionHistoryDto, CONNECTIONS_HISTORY>().ReverseMap();


            


        }
    }
}
