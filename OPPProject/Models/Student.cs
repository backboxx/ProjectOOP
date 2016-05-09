using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Models
{
    public class Student : Person
    {
        public long FacultetNumber { get; set; }
        public string Forma { get; set; }
        public int Kurs { get; set; }
        public string OKS { get; set; }
        public int Groups { get; set; }
        public string Inspector { get; set; }

        public Specialnost Specialnost { get; set; }
        public Facultet Facultet { get; set; }
    }
}
