using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Solution
{
    internal class Parrot : Bird
    {
        public override void Fly()
        {
            
            Console.WriteLine($"this Parrot fly");
        }

        public override void Jump()
        {
            Console.WriteLine($"this Parrot jump");
        }

        public override void Walk()
        {
            Console.WriteLine($"this Parrot walk");
        }
    }
}
