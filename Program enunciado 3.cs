using System;
using System.Collections.Generic;

namespace VerificacionAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>
            {
                { "usuario1", "contraseña1" },
                { "usuario2", "contraseña2" },
                { "usuario3", "contraseña3" }
            };

            Console.WriteLine("Introduce tu nombre de usuario:");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Introduce tu contraseña:");
            string contraseña = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {

                if (usuarios[nombreUsuario] == contraseña)
                {
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
            }
            else
            {
                Console.WriteLine("Usuario no registrado");
            }
        }
    }
}
