using System;

namespace OPC.Solution
{

    internal class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine($"pollo vuela");
        }

        public override void Jump()
        {
            Console.WriteLine($"pollo salta");
        }

        public override void Walk()
        {
            Console.WriteLine($"pollo camina");
        }
    }
}
