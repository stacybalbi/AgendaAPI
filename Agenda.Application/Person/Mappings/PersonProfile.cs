using Agenda.Application.Person.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Person.Mappings
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDto, Domain.Entities.Person>().ReverseMap();

            CreateMap<PersonDto, Domain.Entities.Person>().ForMember(dest => dest.FullName,
                op => op.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<Domain.Entities.Person, PersonDto>();

        }
        
    }
}
