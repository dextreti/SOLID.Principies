
using s= SRP.Solution;
using v=SRP.Violation;
using System;
using SRP.Solution;

namespace SRP
{
    class Program
    {
        /// <summary>
        /// This project exaple single
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Case: violates the principle

            v.Employee vEmpleado = new v.Employee { Name = "Robert", Salary = 80000 };
            var salarycalculate = vEmpleado.CalculateIva(vEmpleado.Salary);
            vEmpleado.Report("Pdf", salarycalculate);


            // case : fulfills the principle
            s.Employee sEmpleado = new s.Employee { Name = "Jhonn", Salary = 50000 };

            s.ICalculate calculate = new s.ServiceCalculate();
            var CalulateSalary = calculate.Iva(sEmpleado.Salary);

            s.IReport<Employee> report = new s.EmployeeReport<Employee>();
            report.Pdf(sEmpleado, CalulateSalary);

            Console.ReadLine();

        }
    }
}
