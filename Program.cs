using System; 
using System.Linq; 
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            int Suma = 0;
            int Resultado = 0;
            int v1 = 4;
            int v2 = 6;
            int v3 = 10;

            Console.WriteLine("");
            Console.WriteLine("Programa para sumar dos numeros y multiplicar por un tercero");
            Console.WriteLine("");
            Console.WriteLine("El primer valor es {0}", v1);
            Console.WriteLine("El segundo valor es {0}", v2);
            Console.WriteLine("El tercer valor es {0}", v3);

            Suma = v1 + v2;
            
            Resultado = Suma * v3;

            Console.WriteLine("");
            Console.WriteLine("En conclusión. La suma de {0} y {1} es {2}, y con la multiplicación de {3} es {4}", v1, v2, Suma, v3, Resultado );

        }

    }
}