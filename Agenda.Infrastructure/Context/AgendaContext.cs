using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infrastructure.Context
{
    public interface IAgendaContext   : IDisposable
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity;
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
    public class AgendaContext : DbContext, IAgendaContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           /* foreach(var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }*/
        }

        public DbSet<T> GetDbSet<T>() where T : BaseEntity => Set<T>();

        private void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>)
            {
                if (entry.State != EntityState.Deleted) continue,
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.Deleted = true;
                }
            }
        }
        public override int SaveChanges()
        {
            SetAuditEntities();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
