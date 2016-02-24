using System;
using Patterns.Structural;
using Patterns.Creational;
using Patterns.Behavioural;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car(new ElectricCar());
            //car.Move();

            //car.Vehicle = new PetrolCar();
            //car.Move();


            Pizza p = new ItalianPizza();
            Console.WriteLine(p.GetCost());

            p = new CheesePizza(p);
            Console.WriteLine(p.GetCost());

            p = new TomatoPizza(p);
            Console.WriteLine(p.GetCost());
            Console.ReadKey();
        }
    }
}
