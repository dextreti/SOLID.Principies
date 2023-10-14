using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Solution
{
    internal class Pigeon : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Este paloma vuela");
        }

        public override void Jump()
        {
            Console.WriteLine("Este paloma salta");
        }

        public override void Walk()
        {
            Console.WriteLine("Este paloma camina");
        }
    }
}
