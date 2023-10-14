using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violation
{
    internal class Pigeon
    {
        public  void Fly()
        {
            Console.WriteLine("Este paloma vuela");
        }

        public void Jump()
        {
            Console.WriteLine("Este paloma salta");
        }

        public void Walk()
        {
            Console.WriteLine("Este paloma camina");
        }
    }
}
