using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    class RegularEmployee: Person, IEmployee , IRegularEmployee
    {
        // SalesEmployee – holds a set of sales.A sale hold product name, date and price.
        // Developer - holds a set of projects.A project holds project name, project start date, details and a project state(open or closed). 
        private double salary;
        private EmploymentDepartment department;
        public double Getsalary()
        {
            return salary;
        }
        public void Setsalary(double value)
        {
            salary = value;
        }

        public RegularEmployee(double salary, EmploymentDepartment EDepartment, string ID, string name, string lastname) : base(ID, name, lastname)
        {
            this.department = EDepartment;
            this.Setsalary(salary);

        }
        public override string ToString()
        {
                           
                return "RegularEmployee #: " + this.GetID() + "\n" + "Fulname" + this.Name + " " + this.LastName +
                    "\n" + "Wage : " + this.Getsalary() + "\n" + "Department:" + this.department + "\n" + "---------------------------";
            
        }
    }
}
