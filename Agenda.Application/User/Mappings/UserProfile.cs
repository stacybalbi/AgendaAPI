using Agenda.Application.User.Dtos;
using Agenda.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.User.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, Domain.Entities.User>().ReverseMap();
            CreateMap<UserPasswordDto, Domain.Entities.User>().ForMember(dest => dest.Person.FullName,
                op => op.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<UserDto, Domain.Entities.Person>().ForMember(dest => dest.FullName, 
                op => op.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<Domain.Entities.Person, UserDto>(); 
        }
    }
}
