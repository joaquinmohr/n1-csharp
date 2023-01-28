
namespace ejercicio1 {

class Program {

    static void Main(string[] args) {

        //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

        int num1, num2, result;
        
        Console.WriteLine("Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.");
        Console.WriteLine("Ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num2 = int.Parse(Console.ReadLine());

        result = num1 + num2;

        Console.WriteLine("El resultado de la suma es: " + result);
        Console.ReadLine();

        }
    }
}