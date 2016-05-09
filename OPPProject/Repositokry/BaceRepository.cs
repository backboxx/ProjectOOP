using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPPProject.Data;

namespace OPPProject.Repositokry
{
    class BaceRepository<TEntity> : IBaceRepository<TEntity> where TEntity : class,new()
    {
        private IOOOPprojectDbContext data;
        private IDbSet<TEntity> set;

        public BaceRepository(OOOPprojectDbContext conntext)
        {
            this.data = conntext;
            this.set = data.Set<TEntity>();
        }
        
        public void Add(TEntity entity)
        {
            UpdateDatabace(entity, EntityState.Added);
        }

        public IQueryable<TEntity> All()
        {
            return this.set;
        }

        public void Remove(TEntity entity)
        {
            UpdateDatabace(entity, EntityState.Deleted);
        }

        public void SaveChanges()
        {
            
        }

        public void Update(TEntity entity)
        {
            UpdateDatabace(entity, EntityState.Modified);
        }
        public void UpdateDatabace(TEntity entity , EntityState state)
        {
            var dbEntry = data.Entry(entity);
            dbEntry.State = state;
        }
    }
}
