using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar las variables
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            // Pedir los valores por teclado
            Console.WriteLine("Introduce un número entero:");
            numeroEntero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un número decimal:");
            numeroDecimal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce un texto:");
            texto = Console.ReadLine();

            Console.WriteLine("Introduce un valor verdadero o falso (true/false):");
            valorBooleano = Convert.ToBoolean(Console.ReadLine());

            // Mostrar los valores en consola
            Console.WriteLine("Número entero: " + numeroEntero);
            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor verdadero o falso: " + valorBooleano);
        }
    }
}
