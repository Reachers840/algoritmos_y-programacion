using System;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int tamano = 5; // <--- Aquí defines cuántos asteriscos tendrá cada lado

            do
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("   MENU DE EJERCICIOS DE BUCLES");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Cuadrado hueco");
                Console.WriteLine("2. Triangulo rectangulo invertido");
                Console.WriteLine("3. Piramide centrada");
                Console.WriteLine("4. Salir");
                Console.WriteLine("==================================");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"CUADRADO HUECO ({tamano}x{tamano})");
                        Console.WriteLine();

                        for (int fila = 1; fila <= tamano; fila++)
                        {
                            for (int columna = 1; columna <= tamano; columna++)
                            {
                                // Si es la primera fila, la última, la primera columna o la última columna
                                if (fila == 1 || fila == tamano || columna == 1 || columna == tamano)
                                {
                                    Console.Write("* "); // Espacio extra para que se vea más cuadrado y menos rectangular
                                }
                                else
                                {
                                    Console.Write("  "); // Dos espacios para alinear con el "* "
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("TRIANGULO RECTANGULO INVERTIDO");
                        Console.WriteLine();

                        for (int fila = tamano; fila >= 1; fila--)
                        {
                            for (int columna = 1; columna <= fila; columna++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("PIRAMIDE CENTRADA");
                        Console.WriteLine();

                        for (int fila = 1; fila <= tamano; fila++)
                        {
                            for (int espacio = 1; espacio <= tamano - fila; espacio++)
                            {
                                Console.Write(" ");
                            }

                            for (int asterisco = 1; asterisco <= 2 * fila - 1; asterisco++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Elija del 1 al 4.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione ENTER para volver al menu...");
                    Console.ReadLine();
                }

            } while (opcion != 4);
        }
    }
}
