using SRP.Violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP.Solution
{
    public class ServiceCalculate : ICalculate
    {
        public double Iva(double amount)
        {
            return amount + new Random().Next(0, 1000);
            
        }

        public double Taxe(double amount)
        {
            return amount + new Random().Next(0, 800);
        }
    }
}
