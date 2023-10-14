using System;

namespace SRP.Violation
{

    public class Robot
    {
        public void Cook(string receta)
        {
            Console.WriteLine("soy concinero:{0}", receta);
        }
        
        public void Painter(string color)
        {
            Console.WriteLine("soy pintor:{0}", color);
        }

        public void Driver(string destino)
        {
            Console.WriteLine("soy conductor:{0}", destino);
        }
    }
}
