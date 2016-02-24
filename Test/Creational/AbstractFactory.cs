using System;

namespace Patterns.Creational
{
    //Dealing with weapon
    public abstract class Weapon
    {
        public abstract void Hit();
    }
    public class Arbalet : Weapon
    {

        public override void Hit()
        {
            Console.WriteLine("Shoot from an arbalet");
        }
    }
    public class Sword : Weapon
    {

        public override void Hit()
        {
            Console.WriteLine("Hit by a sword");
        }
    }

    //Dealing with movement
    public abstract class Movement
    {
        public abstract void Move();
    }
    public class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }
    public class Fly : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }

    //Abstract Factory
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }

    //Running hero with a sword creating factory
    public class Warior : HeroFactory
    {

        public override Movement CreateMovement()
        {
            return new Run();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    //Flying hero with an arbalet creating factory
    public class Elf : HeroFactory
    {

        public override Movement CreateMovement()
        {
            return new Fly();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }

    //Client - is a Hero
    public class Hero 
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        public void Move()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
