using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
     class SalesEmployee : Employee, IEmployee, ISalesEmployee
    {
        //Employee salesemployee;
        //private EmploymentDepartment department;
        public string productname { get; set; }
        public  DateTime productdate { get; set; }
        public string productprice { get; set; }
                      

        public SalesEmployee(string prdname,DateTime prddate,string prdprice, int salary, EmploymentDepartment EDepartment, string ID, string name, string lastname)
                            :base (salary,EDepartment,ID, name,lastname)
        {
            this.SetID(ID);
            this.Setsalary(salary);
            this.productprice = prdprice;
            this.productname = prdname;
            this.productdate = prddate;
            this.Name = name;
            this.LastName = lastname;
            this.DPStatus = EDepartment;


        }
        public override string ToString()
        {

            //return $"SalesEmployee(SalesEmployee #-{this.GetID()},FullName- {Name} {LastName},Wage- {this.Getsalary()},Department of-{DPStatus},Sales product-{productname},{productname},{productdate}";
            return "SalesEmployee #: " + this.GetID() + "\n" + "Fulname" + this.Name + " " + this.LastName +
                   "\n" + "Wage :" + this.Getsalary() + "\n" + "Department:" + this.DPStatus +
                    "\n" + "Sales product:" + this.productname +", "+ this.productdate +", " +this.productprice + "\n" + "---------------------------";

        }


    }
}
