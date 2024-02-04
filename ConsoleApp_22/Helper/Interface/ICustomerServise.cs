using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Model;

namespace Helper.Interface
{
    public interface ICustomerServise
    {
        bool addData(string name,string MobileNumber);
        
        Customer getCustomer(string MobileNumber);
    }
}
