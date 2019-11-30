using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emloyers = new Employee[3];
            
            var Staffemloyers = new[]
        {
            new Employee(20000,EmploymentDepartment.Sales,"HF10","Harry","AAAA"),
            new Employee(90000,EmploymentDepartment.Marketing,"MK2","AAAnn","HGFD"),
            
            new Employee(40000,EmploymentDepartment.Accounting,"AC9","Sharon"," Culbritt"),
            new Employee(50000,EmploymentDepartment.Accounting,"AC9","Sharon"," Culbritt")
        };
            DateTime d = new DateTime (2020,12,15);

            //Console.WriteLine("Employees Records");
            //Console.WriteLine("==========================");
            //foreach (var Member in Staffemloyers)
            //{
            //    Console.WriteLine("Employee #: {0}", Member.GetID());
            //    Console.WriteLine("Full Name:  {0} {1}", Member.Name, Member.LastName );
            //    Console.WriteLine("Department: {0}", Member.DPStatus);
            //    Console.WriteLine("Hourly Wage {0}", Member.Getsalary());
            //    Console.WriteLine("---------------------------");
            //}


            Console.WriteLine("Employees Records tostring");
            Console.WriteLine("==========================");
            
            foreach (var Member in Staffemloyers)
            {
                Console.WriteLine(Member.ToString());
            }
            //    var salsemployees = new[]
            //{
            //    new SalesEmployee("Butter", d, "12$", 20204, EmploymentDepartment.Sales, "HF10", "Harry", "AAAA")

            //};
                                 
            var newmanager = new[]
            {

            new Mananger(Staffemloyers,20000, EmploymentDepartment.Sales, "HF10", "Harry", "AAAA"),
            new Mananger(Staffemloyers,90000, EmploymentDepartment.Marketing, "MK2", "AAAnn", "HGFD"),

            };

            foreach (var Member in newmanager)
            {
                    Console.WriteLine("==========================");
                    Console.WriteLine(Member.ToString());
                
            }

            Person man = new Person("45", "Karen", "Abrahamyan");
            Console.WriteLine(man.ToString());
            Console.WriteLine("==========================");

            //Console.WriteLine(newmanager.employers[0].ToString());
            SalesEmployee salsemployees = new SalesEmployee("Butter", d, "12$", 20204, EmploymentDepartment.Sales, "HF10", "Harry", "AAAA");
            Console.WriteLine(salsemployees.ToString());
            RegularEmployee remployee = new RegularEmployee(70000, EmploymentDepartment.Production, "240", "Kara", "Zurabyan");
            Console.WriteLine(remployee.ToString());

            Console.ReadLine();
        }
    }
}
