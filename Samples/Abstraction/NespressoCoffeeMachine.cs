namespace Samples.Abstraction
{
    public class NespressoCoffeeMachine : CoffeeMachine
    {

        public override void AddWater()
        {
            Console.WriteLine("Adding distilled water");
        }

        public override string MakeCoffee()
        {
            return "Nespresso Coffee Machine Making Coffee";
        }
    }
}