using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"¿{num1} es mayor que {num2}? {num1 > num2}");
        Console.WriteLine($"¿{num1} es menor que {num2}? {num1 < num2}");
        Console.WriteLine($"¿{num1} es igual a {num2}? {num1 == num2}");

        bool andResult = (num1 > 1) && (num2 > 1);
        bool orResult = (num1 > 1) || (num2 > 1);
        
        Console.WriteLine($"¿Ambos números son mayores que 1? {andResult}");
        Console.WriteLine($"¿Al menos uno de los números es mayor que 1? {orResult}");
        Console.WriteLine($"¿si los dos numeros son 0 regresar al principio? {orResult}");
    }
}
