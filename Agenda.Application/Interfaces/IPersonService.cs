﻿using Agenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Interfaces
{
    public interface IPersonService : IBaseCrudService<Person>
    {
    }
}
