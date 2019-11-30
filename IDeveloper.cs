using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    interface IDeveloper
    {
        //holds a set of projects.A project holds project name, project start date, details and a project state(open or closed). 
        DateTime startdate { get; set; }
        string projdetails { get; set; }
        string[] devproject { get; set; }

        bool Projectstate();
    }   
            
}
