using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    public enum EmploymentDepartment
    {
        Production, Accounting, Sales, Marketing,
        Unknown
    };
    public class Employee : Person , IEmployee 
    {

        private double salary;
        private EmploymentDepartment department;
        //private Employee employee;
       

        public double Getsalary()
        {
            return salary;
        }
        public void Setsalary(double value) => salary = value;
        public EmploymentDepartment DPStatus
        {
            get { return department; }
            set { department = value; }
        }

        public override string ToString()
        {
            if (!(!(department is EmploymentDepartment.Unknown)))
            {
                return $"Employee(You don't have any employee with that details)";
            }
            else
            {
                //return $"Employee(Employee #: {this.GetID()},{'\n'} Full Name:{ this.Name} { this.LastName} ,Wage {this.Getsalary()}, department of {this.department})";
                return "Employee #: " + this.GetID()+"\n"+ "Fulname"+ this.Name + " " + this.LastName +
                    "\n"+ "Wage : "+ this.Getsalary()+ "\n" + "Department:" + this.department + "\n"+ "---------------------------";

            } 
            
        }
        
        public Employee(double salary, EmploymentDepartment EDepartment, string ID, string name,string lastname):base(ID, name, lastname)
        {
            this.department = EDepartment;
            this.Setsalary(salary);
           
        }
        public Employee()
        {

        }

        //public Employee(Employee employee)
        //{
        //    this.employee = employee;
        //}

       
    }
}
