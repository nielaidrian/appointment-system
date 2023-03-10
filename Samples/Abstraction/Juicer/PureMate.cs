using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Abstraction.Juicer
{
    public class PureMate : IJuicer
    {
        public void MakeJuice()
        {
            Console.WriteLine("PureMate making juice");
        }
    }
}
