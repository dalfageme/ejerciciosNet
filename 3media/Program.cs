using System;

namespace _3media
{
    class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            
            foreach (string input in args)
            {
                Int32 number = Int32.Parse(input);
                total += number;   
            }

            float resultado = total / args.Length;

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}

// /pazcostea@gmail.com vmhgarcia2@gmail.com  nachomartinezsiles@outlook.com