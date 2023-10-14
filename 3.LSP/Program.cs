using v= LSP.Violation;
using s=LSP.Solution;
using System;

namespace LSP
{
    /// <summary>
    /// Este principio nos dice que si en alguna parte de nuestro código estamos usando una clase, y esta clase es extendida, 
    /// tenemos que poder utilizar cualquiera de las clases hijas y que el programa siga siendo válido
    /// 
    /// Cuando usamos herencia ó extendemos una clase y la clase hija sobrescribe un metodo que no utiliza.
    /// 
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {

            // Viola el principio:

            //v.Bird pato = new v.Duck(); // --> si definimos de esta forma nos daria un error
            v.Pigeon vpigeon = new v.Pigeon();
            vpigeon.Walk();
            vpigeon.Jump();

            v.Duck duck  = new v.Duck();
            duck.Jump();
            duck.Walk();


            // Cumple el principio:

            s.Bird pato = new s.Duck(); 
            s.Bird paloma = new s.Pigeon();

            pato.Walk();
            paloma.Walk();           


            Console.ReadLine();

        }
    }
}
