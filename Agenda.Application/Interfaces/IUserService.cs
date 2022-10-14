using Agenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Application.Generic.Interfaces;

namespace Agenda.Application.Interfaces
{
    public interface IUserService : IBaseCrudService<Domain.Entities.User>
    {

    }
}
