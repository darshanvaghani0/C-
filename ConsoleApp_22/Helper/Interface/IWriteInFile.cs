using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Interface
{
    public interface IWriteInFile
    {
        void WriteLine(string Operation, int a, int b,int ans, string filePath);
    }
}
