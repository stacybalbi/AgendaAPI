using Agenda.Application.Generic.Handlers;
using Agenda.Application.Generic.Interfaces;
using Agenda.Application.Interfaces;
using Agenda.Application.User.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.User.Handlers
{
    public interface IUserHandler : IBaseCrudHandler<UserPasswordDto, Domain.Entities.User>
    {
        new Task<UserDto> GetById(int id);
        new Task<UserPasswordDto> Update(UserPasswordDto dto);
        new Task<UserPasswordDto> Update(int id, UserPasswordDto dto);
        new Task<UserPasswordDto> Create(UserPasswordDto dto);
    }


    public class UserHandler : BaseCrudHandler<UserPasswordDto, Domain.Entities.User>, IUserHandler {

        public UserHandler(IUserService crudService, IMapper mapper) : base(crudService, mapper)
        {

        }
        public new async Task<UserDto> GetById(int id)
        {
            return await base.GetById(id);

        }

        public new async Task<UserPasswordDto> Update(UserPasswordDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<UserPasswordDto> Update(int id, UserPasswordDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<UserPasswordDto> Create(UserPasswordDto dto)
        {
            return await base.Create(dto);
        }
    }
}
