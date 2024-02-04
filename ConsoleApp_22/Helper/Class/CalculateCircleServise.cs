using System;
using Helper.Interface;

namespace Helper.Class
{
    public class CalculateCircleServise : ICalculateCircle
    {
        public double CalculateArea(double radius)
        {
            try
            {
                return 3.14 * radius * radius;
            }
            catch (Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " From CalculateArea Method");
                throw;
            }
        }

        public double CalculatePerimeter(double radius)
        {
            try
            {
                return 2 * 3.14 * radius;
            }
            
            catch (Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " From CalculatePerimeter Method");
                throw;
            }
        }
    }
}
