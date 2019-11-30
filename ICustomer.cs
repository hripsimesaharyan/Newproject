using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    interface ICustomer
    {
        // hold the net purchase amount(total amount of money the customer has spent). 
        double totalamount { get; set; }
    }
}
