using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    public interface IEmployee
    {
        //Employee - general class for all employees, holding the field salary and department.
        //The department can only have one of the following values: Production, Accounting, Sales or Marketing.
        //string salary { get; set; }


        double Getsalary();
        void Setsalary(double value);

        //string department{get;set;}
       
        
    }
}
