
using System;
using s = OPC.Solution;
using v = OPC.Violate;

namespace OCP
{
    /// <summary>
    /// PRINCIPIO OPEN/CLOSE
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Case: viola principio
            
            object[] subjects = new object[2];
            subjects[0] = new v.Duck();
            subjects[1] = new v.Pigeon();
            //subjects[1] = new v.Parrot();
            v.Birds.Add(subjects);


            // Case: cumple principio


            s.Bird[] birds = new s.Bird[]
                {
                new s.Duck(),
                new s.Eagle(),
                //new s.Parrot()
                };
            s.Birds.Add(birds);


            Console.ReadLine();

        }
    }
}
