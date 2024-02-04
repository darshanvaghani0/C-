using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Class
{
    public static class ErrorPrint
    {
        public static void errorPrint(string e)
        {
            try
            {
                string path = @"C:\\Users\\Priya Sutariya\\Desktop\\Darshan Vaghani\\Week 1\\Application\\ConsoleApp_22\\Error File\\" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("--------------------------------------------------------------------------------------");
                    sw.WriteLine(e);
                    sw.WriteLine(DateTime.Now.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }


        }
    }
}
