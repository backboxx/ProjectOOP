using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProject.Models
{
    public class Person : BaceModel
    {
        public string LastName { get; set; }
        public long Egn { get; set; }
        public string Email { get; set; }
    }
}
