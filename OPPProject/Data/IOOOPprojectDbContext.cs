using System.Data.Entity;
using OPPProject.Models;
using System.Data.Entity.Infrastructure;

namespace OPPProject.Data
{
    public interface IOOOPprojectDbContext
    {
        IDbSet<BaceModel> BaceModels { get; set; }
        IDbSet<Facultet> Facultets { get; set; }
        IDbSet<Lecture> Lecturies { get; set; }
        IDbSet<Login> Logins { get; set; }
        IDbSet<Person> Persons { get; set; }
        IDbSet<Predmet> Predmets { get; set; }
        IDbSet<Specialnost> Specialnosti { get; set; }
        IDbSet<Student> Students { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}