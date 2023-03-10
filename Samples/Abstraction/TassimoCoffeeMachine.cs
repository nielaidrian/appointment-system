using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Abstraction
{

    public class TassimoCoffeeMachine : CoffeeMachine
    {

        public override string MakeCoffee()
        {
            return "Tassimo Coffee Machine Making Coffee";
        }
    }
}
