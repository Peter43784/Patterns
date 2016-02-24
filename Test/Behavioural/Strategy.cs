using System;

namespace Patterns.Behavioural
{
    public interface IMovable
    {
        void Move();
    }

    public class PetrolCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Petrol engine is on");
        }
    }

    public class ElectricCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Electric engine is on");
        }
    }

    public class Car
    {
        public IMovable Vehicle;
        public Car(IMovable vehicle)
        {
            Vehicle = vehicle;
        }

        public void Move()
        {
            Vehicle.Move();
        }
    }
}
