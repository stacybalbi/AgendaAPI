using Agenda.Application.Generic.Dto;
using Agenda.Application.Generic.Interfaces;
using Agenda.Application.Interfaces;
using Agenda.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Generic.Handlers
{
    public class BaseCrudHandler<TDto, TEntity> : IBaseCrudHandler<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        private readonly IBaseCrudService<TEntity> _crudService;
        public readonly IMapper _mapper;

        public BaseCrudHandler(IBaseCrudService<TEntity> crudService, IMapper mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }
        public virtual async Task<TDto> Create(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Create(entity);
            return _mapper.Map(entity,dto);
        }

        public async Task<bool> Delete(int id)
        {
            return await _crudService;
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await _crudService.GetById(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public Task<IQueryable<TEntity>> Query()
        {
            return Task.FromResult(_crudService.Query());
        }

        public virtual async Task<TDto> Update(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Update(id,entity);
            return _mapper.Map(entity, dto);
        }

        public virtual async Task<TDto> Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Update(entity);
            return _mapper.Map(entity, dto);
        }
    }
}
