using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    class Mananger:Employee, IEmployee, IMananger
    {


        public Mananger()
        {
           
        }
        public Employee[] employers { get; set; }
        
        public Mananger(Employee[] employers,double salary, EmploymentDepartment EDepartment, string ID, string name, string lastname)
                       :base( salary, EDepartment, ID, name, lastname)
        {
            this.employers = employers;

        }
        public override string ToString()
        {
            //if (!(employers.Length=0))
            //{ 
                //return $"Mananger(The Mananger has Employers - {this.employers})";
                return "Manager #: " + this.GetID() + "\n" + "Fulname" + this.Name + " " + this.LastName +
                  "\n" + "Wage : " + this.Getsalary() + "\n" + "Department:" + this.DPStatus +
                   "\n" + "he has employee"+ this.employers.Length + "\n" + "---------------------------";

            //}

        }
    }
}
