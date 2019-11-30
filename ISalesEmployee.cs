using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newproject
{
    interface ISalesEmployee:IEmployee
    {
        // SalesEmployee – holds a set of sales.A sale hold product name, date and price

        // SalesEmployee – holds a set of sales.A sale hold product name, date and price
        string productname { get; set; }
        DateTime productdate { get; set; }
        string productprice { get; set; }

        
       
    }
}
 