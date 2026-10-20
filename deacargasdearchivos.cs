using System;
namespace Sistema
{

    internal class Program
    {


        static void Main(string[] args)
        {

            int cantidadArchivo = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a Descargar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadArchivo))
                {

                    cantidadArchivo = 0;
                }


            } while (cantidadArchivo <= 0);

            int archivoDescargardos = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivo; i++)
            {

                Console.WriteLine($"\n Archivo {i} Nombre o 'Salir'");
                string name = Console.ReadLine().Trim();

                if (name.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descarga cancelado!!!");
                    break;
                }
                Console.Write("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), result: out tamanio) || tamanio <= 0)
                {

                    Console.WriteLine(">> Tamaño invalido. Archivo omition");
                    continue;
                }


                Console.WriteLine($">> Descargando '{name}' ({tamanio} MB)... OK");
                archivoDescargardos++;
                totalMB += tamanio;

            }
            Console.WriteLine("\n======= RESUMEN DE DESCARGA =======");
            Console.WriteLine($"Archivo Descargados: {archivoDescargardos}");
            Console.WriteLine($"Archivos Descvargados: {totalMB} MB");
            Console.WriteLine("=======================================");
        }
    }
}




