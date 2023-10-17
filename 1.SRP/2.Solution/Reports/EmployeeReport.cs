
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class EmployeeReport<T>: IReport<Employee>
    {
        public void Excel(Employee obj, double Amount)
        {
            Console.WriteLine($"generate report Excel - Salary final :{Amount} - name: {obj.Name}");
        }
     
        public void Pdf(Employee obj, double Amount)
        {
            Console.WriteLine($"generate report Pdf - Salary Final : {Amount} - name: {obj.Name}");
        }
    }
}
