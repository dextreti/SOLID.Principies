using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public interface ICalculate
    {
       double Taxe(double Amount);
       double Iva(double Amount);

    }
}
