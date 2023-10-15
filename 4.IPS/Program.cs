using s= ISP.Solution;
using v= ISP.Violation;
using System;

namespace ISP
{
    /// <summary>
    /// Los objetos no deberían verse forzados a depender de interfaces que no utilizan
    /// las clases no deberian verse forzados a implementar metodos que no utilizan
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Viola el principio
            v.Penguin penguin = new v.Penguin();
            penguin.Walk();
            penguin.Jump();
            penguin.Fly(); // los pinguinos no vuelan, pero la inteface que extiende te obliga a definirlo


            // cumple el principio
            s.Duck duck = new s.Duck();
            duck.Walk();
            duck.Jump();
            duck.Fly();


            Console.ReadLine();

        }
    }
}
