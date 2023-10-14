using SRP.Solution;
using SRP.Violation;
using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Case: viola el principio

            Robot robot = new Robot();
            robot.Cook("preparo un pollo asado");
            robot.Painter("pintare color rojo");
            robot.Driver("te llevo a la laguna");

            // case : cumple el principio

            RobotCook robotCook = new RobotCook();
            robotCook.Cook("preparo un pollo asado");
            RobotDriver robotDriver = new RobotDriver();
            robotDriver.Driver("Te llevo al mirador");
            RobotPainter robotPainter = new RobotPainter();
            robotPainter.Painter("Pintare de color azul");

            Console.ReadLine();

        }
    }
}
