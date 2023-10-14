using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Solution
{
    public class LogManager
    {
        
        private ILogger _logger;
        /// <summary>
        /// Injectamos atraves de una interface Ilogger
        /// </summary>
        /// <param name="logger"></param>
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void LogMessage(string message)
        {
            // High-level module depends on the ILogger abstraction
            _logger.Log(message);
        }
    }
}
