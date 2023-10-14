using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Violation
{
    internal class Duck : IBirds
    {

        public  void Fly()
        {
            Console.WriteLine("Este pato esta volando");
        }

        public void Jump()
        {
            Console.WriteLine("Este pato esta saltando");
        }

        public void Walk()
        {
            Console.WriteLine("Este pato esta caminado");
        }

        
    }
}
