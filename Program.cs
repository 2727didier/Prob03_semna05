using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob03_semna05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de notas: ");
            int cantidadNotas = Convert.ToInt32(Console.ReadLine());
            if (cantidadNotas <= 0)
            {
                Console.WriteLine("La cantidad de notas debe ser mayor que cero.");
                return;
            }
            double sumaNotas = 0;
            for (int i = 1; i <= cantidadNotas; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("La nota debe estar en el rango de 0 a 20.");
                    return;
                }
                sumaNotas += nota;
            }
            double promedio = sumaNotas / cantidadNotas;
            Console.WriteLine($"El promedio de las {cantidadNotas} notas es: {promedio}");
        }
    }

}
    

