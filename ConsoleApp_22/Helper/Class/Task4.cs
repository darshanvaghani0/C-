using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Class
{
    public static class Task4
    {
        public static void print() 
        {
            try
            {
                bool flag4 = true;

                while (flag4)
                {
                    Myprinter.Print("------------------------------");
                    Myprinter.Print("    1 for Calulator(Task 4)");
                    Myprinter.Print("    2 for Exit");

                    int Choise4 = Convert.ToInt32(Console.ReadLine());

                    switch (Choise4)
                    {
                        case 1:
                            Myprinter.Print("    Enter your operation");
                            string operation = Console.ReadLine();

                            Myprinter.Print("    Enter first value");

                            int a = Convert.ToInt32(Console.ReadLine());

                            Myprinter.Print("    secound value");

                            int b = Convert.ToInt32(Console.ReadLine());
                            WriteInFile writeInFile = new WriteInFile();
                            string filePath = "C:\\Users\\Priya Sutariya\\Desktop\\Darshan Vaghani\\Week 1\\Application\\ConsoleApp_22\\ConsoleApp_22\\Input.txt";
                            if (operation.Equals("+"))
                            {
                                writeInFile.WriteLine(operation, a, b, a + b, filePath);
                                Myprinter.Print($"{a}{operation}{b}={a + b}");
                                Myprinter.Print("------------------------------");
                            }
                            else if (operation.Equals("-"))
                            {
                                writeInFile.WriteLine(operation, a, b, a - b, filePath);
                                Myprinter.Print($"{a}{operation}{b}={a - b}");
                                Myprinter.Print("------------------------------");
                            }
                            else if (operation.Equals("/"))
                            {
                                if (b.Equals(0))
                                {
                                    Myprinter.Print("B is Not 0 Enter again");
                                    break;
                                }
                                else
                                {
                                    writeInFile.WriteLine(operation, a, b, a / b, filePath);
                                    Myprinter.Print($"{a}{operation}{b}={a / b}");
                                    Myprinter.Print("------------------------------");
                                }

                            }
                            else if (operation.Equals("*"))
                            {
                                writeInFile.WriteLine(operation, a, b, a * b, filePath);
                                Myprinter.Print($"{a}{operation}{b}={a * b}");
                                Myprinter.Print("------------------------------");
                            }
                            else
                            {
                                Myprinter.Print("Enter Valid Operation");
                                break;
                            }
                            break;

                        case 2:
                            flag4 = false;
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
                ErrorPrint.errorPrint(e.Message + " Error from task4 method");
            }

        }
    }
}
