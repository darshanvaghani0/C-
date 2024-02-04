using System;
using System.IO;
using Helper.Interface;

namespace Helper.Class
{
    public class AddDataFromFile : IAddDataFromFile
    {
        public int addDataFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                int ans = 0;

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    for (int i = 0; i < data.Length; i++)
                    {
                        ans += Convert.ToInt32(data[i]);
                    }
                }

                return ans;
            }
            catch (Exception ex)
            {
                ErrorPrint.errorPrint(ex.Message + " From getCustomer Method");
                throw;
            }
        }
    }
}
