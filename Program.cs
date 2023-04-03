using System;

namespace Decorator.Structural
{


    public class Program
    {
        public static void Main(string[] args)
        {
        
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

          
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.ReadKey();
        }
    }


    public abstract class Component
    {
        public abstract void Operation();
    }


    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Погода ясна");
        }
    }


    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }


    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Погода пасмурна");
        }
    }


    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Падає дощ");
        }

        void AddedBehavior()
        {
        }
    }
}
