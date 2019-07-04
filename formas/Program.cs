using System;

namespace formas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esto da error
            // Rectangulo f = new Forma();
            double b = 3;
            double h = 5;
            // Una variable tipo forma puede contener un rectangulo
            Forma r = new Rectangulo(b, h);
            Forma c = new Cuadrado(b);
            Forma t = new Triangulo((double)10, (double)3, (double)10, (double)10);

            System.Console.WriteLine(r);
            System.Console.WriteLine(c);
            System.Console.WriteLine(t);

            c.Dibujar();
        }
    }
}
