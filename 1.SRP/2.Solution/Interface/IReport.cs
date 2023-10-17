using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    internal interface IReport<in T> 
    {
       void Excel(T obj, double Amount);
       void Pdf(T obj, double Amount);
    }
}
