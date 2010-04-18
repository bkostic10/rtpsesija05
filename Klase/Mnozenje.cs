using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class Mnozenje : TipOperacije
    {
        public override double racunaj(Operacije op)
        {
            return op.A * op.B;
        }
    }
}
