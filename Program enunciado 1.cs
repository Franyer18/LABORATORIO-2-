using System;

namespace CategoriaPorEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            string categoria;

            if (edad < 12)
            {
                categoria = "Niño";
            }
            else if (edad >= 12 && edad <= 17)
            {
                categoria = "Adolescente";
            }
            else if (edad >= 18 && edad <= 59)
            {
                categoria = "Adulto";
            }
            else
            {
                categoria = "Adulto mayor";
            }

            Console.WriteLine("La categoría según tu edad es: " + categoria);
        }
    }
}

