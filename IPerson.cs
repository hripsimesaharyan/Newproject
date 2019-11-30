using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
     public interface IPerson
    {
        string GetID();
        void SetID(string value);

        string Name { get; set; }
        string LastName { get; set; }
        

    }
}
