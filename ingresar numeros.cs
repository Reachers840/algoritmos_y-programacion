using System;
public class HelloWorld {
    public static void Main(string[] args) {
        int numero; 
        int suma = 0;
        int contador = 0;

        do{
            Console.WriteLine("Ingrese un numero (o para salir)");
            numero = int.Parse(Console.ReadLine());
            
            if(numero == 0){
                suma += numero;
                contador++;
            } 
            
        }while(numero != 0);  

        Console.WriteLine($"\nSumA Total; {suma}");
        Console.WriteLine($"Cantidad de numero es: {contador}");

        if(contador > 0){
        Console.WriteLine($"Promedio: {(double)suma/contador:F2}");
        }else{
            Console.WriteLine($"no se Inresaron numeros.");
        }
    }
}    
