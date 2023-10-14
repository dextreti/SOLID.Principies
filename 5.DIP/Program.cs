using s = DIP.Solution;
using v= DIP.Violation;
using System;


namespace DIP
{
    /// <summary>
    ///  Los módulos de alto nivel no deberían depender de los de bajo nivel, ambos deberían depender de abstracciones. 
    ///  Las abstracciones no deben depender de los detalles, los detalles deben depender de las abstracciones.
    ///  
    /// 
    /// Conclusion:
    /// Se entiende como Injeccion de dependencia
    /// Los modulos de bajo nivel contienen componentes que se centran mas en los detalles individuales de la aplicacion
    /// y son usados dentro de los modulos de alto nivel, lo mas importante esque ambos dependan de abstacciones
    /// 
    /// Ejem. Una ordende pedido en una clase de alto nivel y guardar orden, eliminar orden, objtener orden son detalles que necesita
    /// la clase orden para poder guardar el pedido, eliminar el pedido. la clase orden de pedido contiene mas logica que solo eliminar pedidos,    
    /// 
    /// </summary>
    class Program
    {   
        static void Main(string[] args)
        {

            // Viola el principio 
            var vlogManager = new v.LogManager();
            vlogManager.LogMessage("Emitir mensaje usando FileLogger.");

            // Cumple principio
            var fileLogger = new s.FileLogger();
            var slogManager = new s.LogManager(fileLogger);
            slogManager.LogMessage("Emitir mensaje usando FileLogger.");


            Console.ReadLine();

        }
    }
}
