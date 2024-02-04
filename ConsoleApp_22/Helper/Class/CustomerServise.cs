using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Interface;
using Helper.Model;

namespace Helper.Class
{
    public class CustomerServise : ICustomerServise
    {
        List<Customer> Customers;
        public CustomerServise(List<Customer> list)
        {
            Customers = list;
        }

        public bool addData(string name, string MobileNumber)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = name;
                customer.MobileNumber = MobileNumber;
                Customers.Add(customer);
                if (customer != null)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " From addData Method");
                throw;
            }
            

        }

        public Customer getCustomer(string MobileNumber)
        {
            try
            {
                Customer c = Customers.Find(x => x.MobileNumber == MobileNumber);
                if (c != null) return c;

                return null;
            }
            catch (Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " From getCustomer Method");
                throw;
            }
        }
    }
}
