
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OPC.Solution
{
    internal static class Birds
    {
        /// <summary>
        /// Esta clase no se modifica cumple el principio
        /// </summary>
        /// <param name="birds"></param>
        public static void Add(Bird[] birds)
        {
           foreach( var i in birds){
                i.Fly();
                i.Jump();
                i.Walk();
            }
        }
       
    }
}
