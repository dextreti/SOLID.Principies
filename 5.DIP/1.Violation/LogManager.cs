using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Violation
{
    /// <summary>
    /// Esta clase es de alto nivel, es la que gestiona, administra los procesos
    /// </summary>
    public class LogManager
    {
        private FileLogger _fileLogger;
        /// <summary>
        /// Esta clase esta dependiendo de una clase FileLogger de bajo nivel y no de una abstraccion
        /// </summary>
        public LogManager()
        {
            _fileLogger = new FileLogger();
        }

        public void LogMessage(string message)
        {
            // Este implementacion esta dependiendo de una clase directa de bajo nivel y no de una abstracion
            _fileLogger.LogToFile(message);
        }
    }
}
