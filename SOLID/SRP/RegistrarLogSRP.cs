using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class RegistrarLogSRP : ILoggerSRP
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
