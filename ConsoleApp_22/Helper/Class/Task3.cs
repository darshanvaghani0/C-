using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Class
{
    public static class Task3
    {
        public static void print()
        {
            try
            {
                bool flag3 = true;
                while (flag3)
                {
                    Myprinter.Print("------------------------------");
                    Myprinter.Print("    1 for Addition of file data");
                    Myprinter.Print("    2 for Exit");

                    int Choise3 = Convert.ToInt32(Console.ReadLine());

                    switch (Choise3)
                    {
                        case 1:
                            AddDataFromFile addDataFromFile = new AddDataFromFile();
                            int ans = addDataFromFile.addDataFromFile("C:\\Users\\Priya Sutariya\\Desktop\\Darshan Vaghani\\Week 1\\Application\\ConsoleApp_22\\ConsoleApp_22\\Output.txt");
                            Myprinter.Print("Sum of File data is: " + ans);


                            Myprinter.Print("------------------------------");
                            break;
                        case 2:
                            flag3 = false;
                            break;

                        default:
                            Myprinter.Print("    XXXXX--------------------XXXXX");
                            Myprinter.Print("    Enter valid Choise");
                            Myprinter.Print("    XXXXX--------------------XXXXX");
                            break;
                    }

                }
            }
            catch (Exception e)
            {
                ErrorPrint.errorPrint(e.Message + " Error from task3 method");
            }
        }
    }
}
