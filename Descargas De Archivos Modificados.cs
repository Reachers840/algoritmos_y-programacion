
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

            // NUEVO: Validar el espacio disponible en disco
            double espacioDisponible = 0;

            do
            {
                Console.WriteLine("Ingrese el espacio total disponible en disco (MB): ");

                if (!double.TryParse(Console.ReadLine(), out espacioDisponible))
                {
                    espacioDisponible = 0;
                }

            } while (espacioDisponible <= 0);

            int archivoDescargardos = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivo; i++)
            {
                Console.WriteLine($"\n Archivo {i} Nombre o 'Salir'");
                string name = (Console.ReadLine() ?? "").Trim();

                if (name.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descarga cancelado!!!");
                    break;
                }

                // NUEVO: Validar el nombre del archivo
                if (name.Length == 0 || name.Length > 20)
                {
                    Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                    continue;
                }

                Console.Write("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">> Tamaño invalido. Archivo omition");
                    continue;
                }

                // NUEVO: Verificar el espacio disponible
                if (tamanio > espacioDisponible)
                {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }

                // NUEVO: Restar el espacio utilizado
                espacioDisponible -= tamanio;

                Console.WriteLine($">> Descargando '{name}' ({tamanio} MB)... OK");

                // NUEVO: Clasificar el archivo por tamaño
                string categoria;

                if (tamanio < 1)
                {
                    categoria = "Pequeño";
                }
                else if (tamanio <= 10)
                {
                    categoria = "Mediano";
                }
                else
                {
                    categoria = "Grande";
                }

                Console.WriteLine($">> Categoría: {categoria}");

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
