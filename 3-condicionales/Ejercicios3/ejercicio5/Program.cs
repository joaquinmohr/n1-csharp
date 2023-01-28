
namespace ejercicio5 {

    class Program {

        static void Main(string[] args) {

            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLos numeros mayores a 100 son:\n");

            if(num1 > 100){
                Console.WriteLine(num1);
            }
            if(num2 > 100){
                Console.WriteLine(num2);
            }
            if(num3 > 100){
                Console.WriteLine(num3);
            }
            if(num4 > 100){
                Console.WriteLine(num4);
            }
            Console.WriteLine("Fin del programa");
            Console.ReadLine();

        }
    }
}