using System;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorrecto = "soporteDB";
            string contrasenaCorrecta = "Sistemas2025";

            string usuario;
            string contrasena;

            int intentosFallidos = 0;
            bool conexionEstablecida = false;

            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("   VALIDACION DE BASE DE DATOS");
                Console.WriteLine("==================================");

                Console.Write("\nIngrese el usuario: ");
                usuario = Console.ReadLine() ?? "";

                Console.Write("Ingrese la contraseña: ");
                contrasena = Console.ReadLine() ?? "";

                if (usuario.Equals("admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nServidor no disponible.");
                    Console.WriteLine("Reintente mas tarde.");

                    continue;
                }

                if (usuario == usuarioCorrecto &&
                    contrasena == contrasenaCorrecta)
                {
                    Console.WriteLine("\nConexion establecida con la base de datos.");

                    conexionEstablecida = true;
                }
                else
                {
                    intentosFallidos++;

                    Console.WriteLine("\nError de autenticacion.");
                    Console.WriteLine(
                        $"Intento {intentosFallidos} de 3.");
                }

            } while (!conexionEstablecida && intentosFallidos < 3);

            if (intentosFallidos == 3 && !conexionEstablecida)
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("Conexion bloqueada por seguridad.");
                Console.WriteLine("Comuniquese con el administrador del sistema.");
                Console.WriteLine("==================================");
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
