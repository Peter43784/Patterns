using System;

namespace Patterns.Structural
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }

        public Pizza(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }

    public class ItalianPizza : Pizza
    {
        public ItalianPizza(): base("Italian pizza")
        {
            
        }
        public override int GetCost()
        {
            return 10;
        }
    }

    public class BulgarianPizza : Pizza
    {
        public BulgarianPizza() : base("Bulgarian pizza")
        {               
        }
        public override int GetCost()
        {
            return 8;
        }
    }

    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this._pizza = pizza ;
        }

    }

    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p) : base(p.Name + " with tomatoes", p) 
        {
                
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 3;
        }
    }

   public  class CheesePizza : PizzaDecorator
    {
       public CheesePizza(Pizza p) : base(p.Name + " with cheese",p)
       {
            
       }

       public override int GetCost()
       {
           return  _pizza.GetCost() + 5;
       }
    }
}
