using Agenda.Application.Generic.Dto;
using Agenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Generic.Interfaces
{
    public interface IBaseCrudHandler<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        Task<IQueryable<TEntity>> Query();
        Task<TDto> GetById(int id);
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(int id, TDto dto);
        Task<TDto> Update(TDto dto);
        Task<bool> Delete(int id);
    }
}
