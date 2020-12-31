using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisoner
{
    class Criminal
    {
        public string Name { get; set; }
        public int PrisonerID { get; set; }
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public string CrimeDescription { get; set; }
        public string Punishment { get; set; }
        public string CellNo { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string Counselor { get; set; }

        public string[] thread = { "802B73C8658l4", "502B73C847C5" };
    }
}
