using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Violation
{    
    
    internal class Penguin : IBirds
    {
        public void Walk()
        {
            Console.WriteLine("this Elephant is walking");
        }       

        public void Jump()
        {
            Console.WriteLine("this Elephant is Jump");
        }

        /// <summary>
        /// Esta caracteristica rompe el principio de Interface Segrefation Principle
        /// los objetos no deben ser forzados a implementar de metodos que no usa, el pinguino es un ave
        /// que no puede volar 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Fly()
        {
            throw new NotImplementedException();
        }


    }
}
