using ISP.Solution;
using System;

namespace OCP
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
            Penguin penguin = new Penguin();
            penguin.Walk();
            penguin.Jump();
            //penguin.Fly();


            // cumple el principio
            Duck duck = new Duck();
            duck.Walk();
            duck.Jump();
            duck.Fly();


            Console.ReadLine();

        }
    }
}
