using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Solution
{
    internal class Duck : Bird
    {
        public override void Fly()
        {            
            Console.WriteLine("Este pato vuela");
        }

        public override void Jump()
        {
            Console.WriteLine("Este pato salta");
        }

        public override void Walk()
        {
            Console.WriteLine("Este pato camina");
        }
    }
}
