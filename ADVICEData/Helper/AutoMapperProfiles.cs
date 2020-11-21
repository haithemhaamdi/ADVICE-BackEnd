using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ADVICEDto.USER_Dto;
using ADVICEDomaine.Entities;
using ADVICEDto.ROLE_Dto;
using ADVICEDto.BULLETIN_PAIE_Dto;
using ADVICEDto.EMPLOYE_Dto;
using ADVICEDto.DTO;
using ADVICEDto.CONNECTIONS_HISTORY_Dto;

namespace ADVICEData.Helper
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
            CreateMap<BULLETIN_PAIE, BulletinPaieResponseDto>().ReverseMap();


            CreateMap<AddEmployeDto, EMPLOYE>().ReverseMap();
            CreateMap<EditEmployeDto, EMPLOYE>().ReverseMap();
            CreateMap<EMPLOYE, EmployeResponseDto>().ReverseMap();

            CreateMap<AddConnectionHistoryDto, CONNECTIONS_HISTORY>().ReverseMap();


            


        }
    }
}
