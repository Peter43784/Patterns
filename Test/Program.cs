using System;
using Patterns.Structural;
using Patterns.Creational;
using Patterns.Behavioural;
using Patterns.SOLID._1SingleResponsibilityPrinciple;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

			ProductB p1 = new ProductB {Price = 100};
	        Console.WriteLine( p1.IsValid( new ValidatorA() ) );
			p1.Price = 10;
	        Console.WriteLine( p1.IsValid( new ValidatorB() ) );
			p1.Price = 0;
			Console.WriteLine( p1.IsValid( new ValidatorA() ) );




			//Car car = new Car(new ElectricCar());
			//car.Move();

			//car.Vehicle = new PetrolCar();
			//car.Move();


			//Pizza p = new ItalianPizza();
			//Console.WriteLine(p.GetCost());

			//p = new CheesePizza(p);
			//Console.WriteLine(p.GetCost());

			//p = new TomatoPizza(p);
			//Console.WriteLine(p.GetCost());
			Console.ReadKey();
        }
    }
}
