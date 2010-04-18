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
        private TipOperacije _tip;


        private Operacije(double a, double b, char operacija)
        {
            _a = a;
            _b = b;
            _operacija = operacija;
            _tip = new TipOperacije();
        }
        public double racunaj()
        {
            return _tip.racunaj(this);
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

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }
        public char Operacija
        {
            get { return _operacija; }
            set { _operacija = value; }
        }
    }
}
