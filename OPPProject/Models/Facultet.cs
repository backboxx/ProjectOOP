using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Models
{
    public class Facultet: BaceModel
    {
        public string Leder { get; set; }
        public IEnumerable<Specialnost> Specialnosti { get; set; }

    }
}
