using System;

namespace NombreDiadelasemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número del 1 al 7:");
            int numero = Convert.ToInt32(Console.ReadLine());
            string dia;

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Número inválido";
                    break;
            }

            Console.WriteLine("El día correspondiente es: " + dia);
        }
    }
}
