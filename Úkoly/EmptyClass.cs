using System;
namespace Úkoly
{
    class Class1
    {

        private double a;
        private double b;
        /*
        //konstruktor
        public Class1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        */

        public void Vystup()
        {
            Console.WriteLine("Zadejte první číslo:");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x)){
                Console.WriteLine("Špatně zadejte znova:");
            }

            Console.WriteLine("Zadejte druhé číslo:");
            double y;
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Špatně zadejte znova:");
            }

            Console.WriteLine("Součet: {0}", Soucet(x,y));
        }

        private double Soucet(double a, double b)
        {
            return a + b;
        }
    }
}
