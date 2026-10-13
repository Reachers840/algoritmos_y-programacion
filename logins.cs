using System;
using System.CodeDom;

internal class Program
{
    static void Main(string[] args)
    {
        string correoCorrecto = "rmalaver@unicaribe.edu.co";
        string passCorrecto = "richard2o";

        string email = "";
        string pass = "";

        int intentos = 0;
        while (intentos < 3)
        {
            Console.WriteLine("Ingrese tu correo: ");
            email = Console.ReadLine();

            Console.WriteLine("Ingrese tu contraseña: ");
            pass = Console.ReadLine();

            if (email == correoCorrecto && pass == passCorrecto)
            {
                Console.WriteLine("Bienvenido a la plataforma de UNICARIBE!!");
                break;
            }
            else
            {
                intentos++;
                Console.WriteLine("Correo o Contraseña INCORRECTO!!");
                Console.WriteLine("Intentos Restantes: " + (3 - intentos));

            }
        }
        if (intentos == 3)
        {
            Console.WriteLine("Usuario Bloqueado - Comunicado con T.I UNICARIBE");
        }
    }
}
