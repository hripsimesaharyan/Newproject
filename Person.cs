using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
        public class Person:IPerson
    {
        private string iD;

        public string GetID()
        {
            return iD;
        }

        public void SetID(string value)
        {
            iD = value;
        }

        public string Name { get; set; }
        public string LastName { get; set; }

        public Person (string ID, string name ,string lastname)
        {
            this.SetID(ID);
            this.Name = name;
            this.LastName = lastname;
        }

        public override string ToString()
        {
            return $"Person(Person #-{this.GetID()}, Full Name-{this.Name} {this.LastName})";
        }

        public Person()
        {

        }



    }
}
