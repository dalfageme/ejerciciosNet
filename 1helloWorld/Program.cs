// David Alfageme 1-7-2019
using System;

namespace _1helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 numero1 = Convert.ToInt16(args[0]);
            Int16 numero2 = Convert.ToInt16(args[1]);
            Int32 resultado = numero1 * numero2;

            Double numeroDoble = 123456.78;
            Int32 numeroInt = (Int32)numeroDoble;


            Console.WriteLine("Numero doble " + numeroDoble + " int " + numeroInt); 

            Console.WriteLine("El resultado es: ".ToUpper() + (numero1 * numero2));
            
            String bisiesto = Program.bisiesto(2005) ? "bisiesto" : "no";
            Console.WriteLine("El resultado es: "+ bisiesto  );

        }
        static bool bisiesto(Int32 year){
            return year % 4 == 0;
        }
    }

}
