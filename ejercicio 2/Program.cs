using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        Console.WriteLine("Ingrese un numero:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese otro número:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
    }
}
