using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Solution
{
    internal class Penguin : IWalk, IJump
    {
        public void Jump()
        {
            Console.WriteLine("Este pinguino salta");
        }

        public void Walk()
        {
            Console.WriteLine("Este pinguino camina");
        }
    }
}
