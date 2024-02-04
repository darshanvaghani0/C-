using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Interface;

namespace Helper.Class
{
    public class WriteInFile : IWriteInFile
    {
        
        public void WriteLine(string Operation, int a, int b,int ans, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{a}{Operation}{b}={ans}");

                }
            }
            catch(Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " from WriteFile Mrthod");
            }
            
        }
    }
}
