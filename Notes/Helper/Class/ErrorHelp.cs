using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Class
{
    public static class ErrorHelp
    {
        public static void ErrorPrint(string ex)
        {
            string path = @"C:\\Users\\Priya Sutariya\\Desktop\\Darshan Vaghani\\Week 1\\Practice\\Notes\\Error\\" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("-------------------------------------------------------------");
           
                 sw.WriteLine(ex);
                sw.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
