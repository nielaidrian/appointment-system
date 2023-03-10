namespace Samples.Abstraction
{
    //1. Abstract classes
    //2. Interfaces

    public abstract class CoffeeMachine
    {
        public virtual void AddWater()
        {
            Console.WriteLine("Adding water");
        }

        public abstract string MakeCoffee();
    }

    public interface ICoffeeMachine
    { 
        string MakeCoffee();
    }

    public class BrevilleCoffeeMachine : ICoffeeMachine
    {
        public string MakeCoffee()
        {
            return "Breville Coffee Machine Making Coffee";
        }
    }
}
