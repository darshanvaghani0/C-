using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Class
{
    public static  class Task2
    {
        public static void print()
        {
            try
            {
                bool flag2 = true;
                while (flag2)
                {
                    Myprinter.Print("------------------------------");
                    Myprinter.Print("    1 for Enter the radius of the circle");
                    Myprinter.Print("    2 for Exit");

                    int Choise2 = Convert.ToInt32(Console.ReadLine());

                    switch (Choise2)
                    {
                        case 1:
                            Myprinter.Print("    Enter the radius of the circle");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            CalculateCircleServise calculateCircleServise = new CalculateCircleServise();
                            double area = calculateCircleServise.CalculateArea(radius);
                            double perimeter = calculateCircleServise.CalculatePerimeter(radius);

                            Myprinter.Print($"    Area of the circle: {area}");
                            Myprinter.Print($"    Perimeter of the circle: {perimeter}");
                            Myprinter.Print("------------------------------");
                            break;
                        case 2:
                            flag2 = false;
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
                ErrorPrint.errorPrint(e.Message + " Error from task2 method");
            }



        }
    }
}
