using System;

namespace SRP.Violation
{

    /// <summary>
    /// This class implement all methods violation pattern
    /// </summary>
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public double CalculateTaxes(double Amount)
        {
            return Amount + new Random().Next(0, 100);
        }

        public double CalculateIva(double Amount)
        {
            return Amount + new Random().Next(0, 200); ;
        }
        public void Report(string TypeFortmat, double CalculateSalary)
        {

            if (TypeFortmat == "Xls")
                GenerateExcel(CalculateSalary);

            if (TypeFortmat == "Pdf")
                GeneratePdf(CalculateSalary);
        }

        private void GenerateExcel(double salaryCalculateEmployee) {            
            Console.WriteLine($"generate report Excel - Salary final :{salaryCalculateEmployee} - name: {Name}");
        }
        private void GeneratePdf(double salaryCalculateEmployee)
        {
            
            Console.WriteLine($"generate report Pdf - Salary final :{salaryCalculateEmployee} - name: {Name}");
        }
       
    }

}
