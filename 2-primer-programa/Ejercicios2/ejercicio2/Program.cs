namespace ejercicio2 {

class Program {

    static void Main(string[] args) {

        //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

        int num, result;
        Console.WriteLine("Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.");
        Console.WriteLine("Ingrese un numero");
        num = int.Parse(Console.ReadLine());

        result = num * num * num;

        Console.WriteLine("el numero " + num + " al cubo es " + result);
        Console.ReadLine();

        }
    }
}