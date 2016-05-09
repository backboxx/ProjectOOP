using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Models
{
    public class Predmet : BaceModel
    {
        public int Kours { get; set; }
        public Lecture Lecture { get; set; }
    }
}
