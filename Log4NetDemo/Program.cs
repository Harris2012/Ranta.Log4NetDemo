using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace TestLog4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog logger = LogManager.GetLogger(typeof(Program).FullName);

            logger.Error("this is error.");

            logger.Info("this is info.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
