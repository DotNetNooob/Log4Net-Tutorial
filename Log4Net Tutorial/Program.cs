using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net_Tutorial
{
    // Follow this Link , Its super easy and effective
    // https://stackify.com/log4net-guide-dotnet-logging/

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Hello logging world!");
            log.Error("What is going On");
            Console.WriteLine("Hit enter");
            Console.ReadLine();
        }
    }
}
