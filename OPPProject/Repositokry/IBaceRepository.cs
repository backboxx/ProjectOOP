using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Repositokry
{
    interface IBaceRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();


    }
}
