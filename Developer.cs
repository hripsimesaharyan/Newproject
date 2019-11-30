using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    class Developer :Employee, IEmployee, IDeveloper
    {
        public bool prstate = false;

        public DateTime startdate { get; set; }
        public string projdetails { get; set; }
        public string[] devproject { get; set; }

        public bool Projectstate() => prstate = true;



    }
}
