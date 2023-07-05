using Agenda.Application.Interfaces;
using Agenda.Domain.Entities;
using Agenda.Infrastructure.Context;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infrastructure.Services
{
    public class BaseCrudServices<TEntity> : IBaseCrudService<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> DbSet;
        private readonly IAgendaContext _dbcontext;
        private readonly IMapper _mapper;

        public BaseCrudServices(IAgendaContext dbcontext, IMapper mapper)
        {
            DbSet = dbcontext.GetDbSet<TEntity>();
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            await DbSet.AddSync(entity);
            await _dbcontext.SaveChanges();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null) throw new Exception($"Error deleting entity. Entity with id {id} not found");
            DbSet.Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> Get(int top = 50)
        {
            return Query().Take(top).ToList();
        }

        public async Task<TEntity> GetById(int id)
        {
            return (await Query().FirstOrDefaultAsync(entity => entity.Id == id))!;
        }

        public IQueryable<TEntity> Query()
        {
            return DbSet.AsQueryable();
        }

        public async Task<TEntity> Update(int id, TEntity entity)
        {
            if(id != entity,Id) throw new Exception("Ids doesn't match");
            var existingEntity = await GetById(id);
            _mapper.Map();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
