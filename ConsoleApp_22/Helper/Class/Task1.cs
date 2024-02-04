using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Model;

namespace Helper.Class
{
    public static class Task1
    {
        public static void print()
        {
            try
            {
                bool flag1 = true;
                List<Customer> list = new List<Customer>();
                while (flag1)
                {
                    Myprinter.Print("------------------------------");
                    Myprinter.Print("    Enter your Choise:");
                    Myprinter.Print("    1 For addRecord");
                    Myprinter.Print("    2 For getRecord");
                    Myprinter.Print("    3 For Exit");
                    int Choise1 = Convert.ToInt32(Console.ReadLine());
                    CustomerServise customerServise = new CustomerServise(list);
                    switch (Choise1)
                    {
                        case 1:
                            Myprinter.Print("    Enter your Name:");
                            string name = Console.ReadLine();
                            Myprinter.Print("    Enter your mobile number:");
                            string mobileNumber = Console.ReadLine();

                            bool result = customerServise.addData(name, mobileNumber);

                            if (result)
                            {
                                Myprinter.Print("    Data added successfully");
                                Myprinter.Print("------------------------------");
                            }
                            else
                            {
                                Myprinter.Print("    Note Added");
                                Myprinter.Print("------------------------------");
                            }
                            break;


                        case 2:
                            Myprinter.Print("------------------------------");
                            Myprinter.Print("    Enter Mobile Number");
                            string MobileNumber = Console.ReadLine();
                            Customer c = customerServise.getCustomer(MobileNumber);
                            if (c != null)
                            {
                                Myprinter.Print("    Customer Name is :" + c.Name);
                                Myprinter.Print("    Customer Mobile Number is :" + c.MobileNumber);
                                Myprinter.Print("------------------------------");
                            }
                            else
                            {
                                Myprinter.Print("    Customer is Not Found");
                                Myprinter.Print("------------------------------");

                            }
                            break;

                        case 3:
                            flag1 = false;
                            break;

                        default:
                            Myprinter.Print("    XXXXX--------------------XXXXX");
                            Myprinter.Print("    Enter valid Choise");
                            Myprinter.Print("    XXXXX--------------------XXXXX");
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                ErrorPrint.errorPrint(e.Message + " Error from task1 method");
            }
            }
            
    }
}