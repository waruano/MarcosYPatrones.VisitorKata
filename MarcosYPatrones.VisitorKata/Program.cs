using System;

namespace MarcosYPatrones.VisitorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            IVisitor bullet = new TankBullet();
            ILightUnit light = new Marine(); 
            IArmoredUnit armored = new Marauder();
            do
            {
                Console.WriteLine("Press 1 to shoot the Marine or 2 to shoot the Marauder.");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        light.Accept(bullet);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        armored.Accept(bullet);
                        break;
                    default:
                        continueProgram = false;
                        break;
                }
                Console.WriteLine();
                showMarineHealth(light);
                showMarauderHealth(armored);

            } while (continueProgram);
        }

        private static void showMarineHealth(ILightUnit marine)
        {
            if(marine.Health > 0)
                Console.WriteLine($"Marine's Health is {marine.Health}");
            else
                Console.WriteLine($"The Marine is dead");
        }

        private static void showMarauderHealth(IArmoredUnit marauder)
        {
            if (marauder.Health > 0)
                Console.WriteLine($"Marauder's Health is {marauder.Health}");
             else
                Console.WriteLine($"The Marauder is dead");
        }
    }
}
