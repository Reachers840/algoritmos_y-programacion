using System;


public class HelloWorld {
  public static void Main(string[] arga) {

    const string passCorrecta = "admin123";
    string clave;
    int intentosfallidos = 0;

    do{
       Console.Write("Ingrese la contraseña");
       clave = Console.ReadLine();
       if (clave != passCorrecta){
         intentosfallidos++;
         Console.WriteLine("Contraseña incorrecta. intentalo de nuevo.");
     }

  } while (clave != passCorrecta);
      Console.WriteLine($"\n Acesso concedido.");
      Console.WriteLine($"Intentos fallidos; (intentosfallidos)");
  }
}
