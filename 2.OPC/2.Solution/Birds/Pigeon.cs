using System;

namespace OPC.Solution
{
    internal class Pigeon : Bird
    {
        public override void Fly()
        {
            
            Console.WriteLine($"this Pigeon fly");
        }

        public override void Jump()
        {
            Console.WriteLine($"this Pigeon jump");
        }

        public override void Walk()
        {
            Console.WriteLine($"this Pigeon walk");
        }
    }
}
