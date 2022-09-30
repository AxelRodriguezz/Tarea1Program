using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes;
            int[] notas;
            estudiantes = new String[5];
            notas = new int[5];
            Console.WriteLine(estudiantes.Length);
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante " + (i + 1) + ": ");
                estudiantes[i] = Console.ReadLine();
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("Ingrese la nota " + (x + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    notas[x] = int.Parse(linea);
                }
            }
            float sumatoria = 0;
            int mayor = notas[0];
            int indice = 0;
            for (int i = 0; i < notas.Length; i++)
            {
             sumatoria += notas[i];
            }
            sumatoria /= 3;
            int contador = 0;
            while (indice < notas.Length)
            {
                if (notas[indice] > sumatoria)
                {
                    contador++;
                }
                indice++;
            }
            Console.WriteLine("Promedio: " + sumatoria);
            Console.WriteLine("estudiantes con nota superior al promedio: " + contador);
            int opcion = 0;
            do
            {
                Console.WriteLine("1- opcion 1");
                Console.WriteLine("2- opcion 2");
                Console.WriteLine("3- opcion 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" Opcion 1 ");
                        break;
                    case 2:
                        Console.WriteLine("Opcion 2 ");
                        break;
                    case 3:
                        Console.WriteLine("Opcion 3 ");
                        break;
                    case 4: break;
                    default:
                        Console.WriteLine(" Salir ");
                        break;
                }

            } while (opcion != 3);


            Console.Read();
        

    }
    }
}

