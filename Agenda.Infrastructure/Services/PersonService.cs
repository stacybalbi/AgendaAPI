using Agenda.Application.Interfaces;
using Agenda.Domain.Entities;
using Agenda.Infrastructure.Context;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infrastructure.Services
{
    public class PersonService : BaseCrudServices<Person>, IPersonService
    {
        public PersonService(IAgendaContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }
    }
}
