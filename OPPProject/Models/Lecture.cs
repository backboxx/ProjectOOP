using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Models
{
    public class Lecture: BaceModel
    {
        public int Kabinet { get; set; }
        public long Tel { get; set; }

        public IEnumerable<Predmet> Predmet { get; set; }
        public IEnumerable<Specialnost> Specialnost { get; set; }
    }
}
