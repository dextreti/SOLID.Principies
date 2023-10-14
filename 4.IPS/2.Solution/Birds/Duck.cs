using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Solution
{
    internal class Duck : IWalk, IJump, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Este pato vuela");
        }

        public void Jump()
        {
            Console.WriteLine("Este pato Salta");
        }

        public void Walk()
        {
            Console.WriteLine("Este pato camina");
        }
    }
}
