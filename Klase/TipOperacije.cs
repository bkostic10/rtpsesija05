using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class TipOperacije
    {
        public double racunaj(Operacije op)
        {
            if (op.Operacija == '+')
                return op.A + op.B;
            if (op.Operacija == '-')
                return op.A - op.B;
            if (op.Operacija == '*')
                return op.A * op.B;
            else return op.A / op.B;
        }
    }
}
