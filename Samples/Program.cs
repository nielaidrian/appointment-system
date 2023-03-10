﻿using Samples.Abstraction;
using Samples.Abstraction.Juicer;
using System;

namespace Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Always program against an abstraction - good programmer
            //CoffeeMachine nespressoCoffeeMachine = new NespressoCoffeeMachine();
            //CoffeeMachine tassimoCoffeeMachine = new TassimoCoffeeMachine();

            //string nespresso = nespressoCoffeeMachine.MakeCoffee();

            //string tassimo = tassimoCoffeeMachine.MakeCoffee();

            //Console.WriteLine("NESPRESSO");
            //nespressoCoffeeMachine.AddWater();
            //Console.WriteLine(nespresso);
            //Console.WriteLine();
            //Console.WriteLine("TASSIMO");
            //tassimoCoffeeMachine.AddWater();
            //Console.WriteLine(tassimo);

            //Console.ReadLine();

            IJuicer pureMate = new PureMate();
            IJuicer dualit = new Dualit();
            IJuicer livivo = new Livivo();

            MakeJuice(pureMate);
            MakeJuice(dualit);
            MakeJuice(livivo);

            Console.ReadLine();

        }

        static void MakeJuice(IJuicer juicer)
        {
            juicer.MakeJuice();
        }
    }
}