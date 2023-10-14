using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Violation
{
    // Esta clase es de bajo nivel
    public class FileLogger
    {
        public void LogToFile(string message)
        {
            // Code to log to a file
            Console.WriteLine("Logged to file: " + message);
        }
    }
}
