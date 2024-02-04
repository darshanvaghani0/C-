using Helper.Class;
using Helper.Interface;
using Helper.Model;

namespace ConsoleApp_22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                


                while (flag)
                {
                    Myprinter.Print("------------------------------");
                    Myprinter.Print("Enter your Choise:");
                    Myprinter.Print("1 For Customer Data(Task 1)");
                    Myprinter.Print("2 For Area And Perimeter of circule(Task 2)");
                    Myprinter.Print("3 For Addition of your file data(Task 3)");
                    Myprinter.Print("4 For Calculator(Task 4)");
                    Myprinter.Print("5 For Exit");
                    int Choise = Convert.ToInt32(Console.ReadLine());
                    switch (Choise)
                    {
                        case 1:
                            Task1.print();
                            break;

                        case 2:
                            Task2.print();
                            break;


                        case 3:
                            Task3.print();
                            break;

                        case 4:
                            Task4.print();
                            break;


                        case 5:
                            flag = false;
                            break;

                        default:
                            Myprinter.Print("XXXXX--------------------XXXXX");
                            Myprinter.Print("Enter valid Choise");
                            Myprinter.Print("XXXXX--------------------XXXXX");
                            break;
                    }
                    Myprinter.Print("------------------------------");
                }
            }
            catch (Exception e)
            {
                ErrorPrint.errorPrint(e.Message+" From main method");
            }

        }
    }
}