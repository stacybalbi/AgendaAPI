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
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, Domain.Entities.User>().ReverseMap();
            CreateMap<UserPasswordDto, Domain.Entities.User>().ReverseMap();
            
            CreateMap<UserDto,Person>().ForMember(dest => dest.FullName, op = op.MapFrom(source => $"{source.FirstName} {source.LastName}"));
            CreateMap<Person, UserDto>();
        }
    }
}
