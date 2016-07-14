using System;
using Patterns.Structural;
using Patterns.Creational;
using Patterns.Behavioural;
using Patterns.SOLID._1SingleResponsibilityPrinciple;

namespace Patterns
{
    class Program
    {
		static void Do() {
			try {
				throw new ArgumentException();
			} catch( OverflowException e ) {
				
			} finally {
				Console.WriteLine( "In finally" );
			}
		}
        static void Main(string[] args)
        {
			try {

				Do();

			} catch { } finally {
				Console.WriteLine( "f" );
			}
			
		



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
