using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            double  numero, edad, nota1, nota2, parcial, definitiva;
            for (int i = 1; i <= 26; i++)
            {
                Console.WriteLine("Ingrese el numero del estudiante:");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del estudiante:");
                nombre = String.Format (Console.ReadLine());
                Console.WriteLine("Ingrese edad del estudiante:");
                edad = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una nota");
                nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otra nota");
                nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otra nota");
                parcial = double.Parse(Console.ReadLine());


                definitiva = (nota1 * 0.30) + (nota2 * 0.30) + (parcial * 0.40);


                if (definitiva >= 6)
                    Console.WriteLine("aprobado");
                else
                    Console.WriteLine("reprobado");
                Console.WriteLine("Valor de promedio: " + definitiva);
                Console.WriteLine();
                Console.Write("============Resultados============ ");
                definitiva = double.Parse(Console.ReadLine());

            }
            Console.ReadLine();

        }

    }
}

