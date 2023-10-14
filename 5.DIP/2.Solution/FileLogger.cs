using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Solution
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Code to log to a file
            Console.WriteLine("Logged to file: " + message);
        }
    }

}
