using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class Operacije
    {
        private char _operacija;
        private double _b;
        private double _a;


        private Operacije(double a, double b, char operacija)
        {
            _a = a;
            _b = b;
            _operacija = operacija;
        }
        public double racunaj()
        {
            if (_operacija == '+')
                return _a + _b;
            if (_operacija == '-')
                return _a - _b;
            if (_operacija == '*')
                return _a * _b;
            else return _a / _b;
        }
        public static Operacije sabiranje(double a, double b)
        {
            return new Operacije(a, b, '+');
        }
        public static Operacije oduzimanje(double a, double b)
        {
            return new Operacije(a, b, '-');
        }
        public static Operacije mnozenje(double a, double b)
        {
            return new Operacije(a, b, '*');
        }
        public static Operacije deljenje(double a, double b)
        {
            return new Operacije(a, b, '/');
        }
    }
}
