﻿using System;

namespace formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo f = new Forma();
            double b = 10;
            double h = 5;
            // Una variable tipo forma puede contener un rectangulo
            Forma r = new Rectangulo(b, h);
        }
    }
}
