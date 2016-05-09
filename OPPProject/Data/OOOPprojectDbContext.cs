using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPPProject.Models;

namespace OPPProject.Data
{
    public class OOOPprojectDbContext : DbContext, IOOOPprojectDbContext
    {
        public OOOPprojectDbContext(): base("ProjectOOpDB")
        {

        }

        public IDbSet<BaceModel> BaceModels { get; set; }
        public IDbSet<Facultet> Facultets { get; set; }
        public IDbSet<Lecture> Lecturies { get; set; }
        public IDbSet<Login> Logins { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<Predmet> Predmets { get; set; }
        public IDbSet<Specialnost> Specialnosti { get; set; }
        public IDbSet<Student> Students { get; set; }


    }
}
