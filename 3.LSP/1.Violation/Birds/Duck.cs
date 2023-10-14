using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violation
{
    internal class Duck
    {
        public  void Fly()
        {            
            Console.WriteLine("Este pato vuela");
        }

        public void Jump()
        {
            Console.WriteLine("Este pato salta");
        }

        public void Walk()
        {
            Console.WriteLine("Este pato camina");
        }
    }
}
