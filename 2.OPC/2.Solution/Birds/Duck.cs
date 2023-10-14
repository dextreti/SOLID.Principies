using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Solution
{
    internal class Duck : Bird
    {
        public override void Fly()
        {
            Console.WriteLine($"this Duck fly");
        }

        public override void Jump()
        {
            Console.WriteLine($"this duck Jump");
        }

        public override void Walk()
        {
            Console.WriteLine($"this duck walk");
        }
    }
}
