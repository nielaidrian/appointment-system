using Samples.Abstraction;
using System;

namespace Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Always program against an abstraction
            CoffeeMachine nespressoCoffeeMachine = new NespressoCoffeeMachine();
            CoffeeMachine tassimoCoffeeMachine = new TassimoCoffeeMachine();

            string nespresso = nespressoCoffeeMachine.MakeCoffee();
            string tassimo = tassimoCoffeeMachine.MakeCoffee();

            Console.WriteLine(nespresso);
            Console.WriteLine(tassimo);

            Console.ReadLine();
        }
    }
}