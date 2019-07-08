using System;
using System.Collections.Generic;

namespace diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo seleccion;
            SortedList<string, string> diccionario = new SortedList<string, string>();
            do
            {
                PrintMenu();
                seleccion = Console.ReadKey();
                switch (seleccion.Key) {
                    case ConsoleKey.D1:
                        introducirPalabras(ref diccionario);
                        break;
                    case ConsoleKey.D2:
                        buscarPalabras(diccionario);
                        break;
                    case ConsoleKey.D3:
                        foreach(var p in diccionario)
                        {
                            Console.WriteLine("{0}:  {1}", p.Key, p.Value);
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("No válida");
                        break;
                }
            } while (seleccion.Key != ConsoleKey.Escape);      
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1) Añadir palabras");
            Console.WriteLine("2) Buscar palabras");
            Console.WriteLine("3) Mostrar todas");
            Console.WriteLine("esc) Salir");
        }

        static void introducirPalabras(ref SortedList<string, string> diccionario)
        {
            Console.WriteLine("Introduce las palabras");
            string input;
            do
            {
                Console.Clear();
                Console.Write("Palabra: ");
                input = Console.ReadLine();
                if (input.Length > 0)
                {
                    Console.Write("Definicion: ");
                    string definicion = Console.ReadLine();
                    // todo comprobar si ya existe
                    bool insertada = diccionario.TryAdd(input.ToLower(), definicion);
                    Console.WriteLine(insertada ? "Palabra insertada" : "No se pudo insertar");
                    Console.ReadKey();
                }
            } while (input.Length > 0);
        }

        static void buscarPalabras(SortedList<string, string> diccionario)
        {
            Console.Clear();
            Console.WriteLine("Busqueda");
            Console.Write("Palabra: ");
            string busqueda = Console.ReadLine().ToLower();
            string encontrada;
            if (diccionario.TryGetValue(busqueda, out encontrada))
            {
                Console.WriteLine("Palabra encontrada");
                Console.WriteLine("{0}: {1}", busqueda, encontrada);
            }
            else
            {
                Console.WriteLine("No se encontró {0}", busqueda);
            }
            Console.ReadKey();
        }
    }
}
