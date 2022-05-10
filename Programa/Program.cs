using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion_menu = 0;
            do
            {
                Console.Write("\n|----------------------|--------------------|");
                Console.Write("\n| 1. Calcular la suma de (n) numeros primeros|");
                Console.Write("\n| 2. Calcular Factorial de un numero|");
                Console.Write("\n| 3. Calcular el mayor de 3 numero|");
                Console.Write("\n| 4. Encontrar la Potencia de un numero|");
                Console.Write("\n| 5. Salir|");
                Console.Write("\n|----------------------|--------------------|");
                Console.Write("\nEscoja una Opcion: ");
                opcion_menu = int.Parse(Console.ReadLine());
                switch (opcion_menu)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad de N numero\n");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("La suma total es: " + calcular_suma(n));
                        break;
                    case 2:
                        Console.Write("Ingrese el numero que desea calcular\n");
                        int num = int.Parse(Console.ReadLine());
                        Console.Write("El factorial de: " + num + "! es:" + factorial(num));
                        break;
                    case 5:
                        Console.Write("\n\nPROGRAMA FINALIZADO.\n\n");
                        break;
                    default:
                        Console.Write("\n\nOPCIÓN INCORRECTA.\n\n");
                        break;





                }

            } while (opcion_menu != 11);
        }

        static int calcular_suma(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
            }
            return suma;
        }

        static int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

    }
}

