
namespace ejercicio4 {

    class Program {

        static void Main(string[] args) {

            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a, b, c, suma, producto;

            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            c = int.Parse(Console.ReadLine());

            suma = a + b;
            producto = b * c;

            if(suma > producto){
                Console.WriteLine("La suma de los dos primeros es mayor la producto del segundo con el tercero");
            }else{
                Console.WriteLine("La suma del primero con el segundo NO es mayor al producto del segundo con el tercero");
            }
            Console.WriteLine("Fin del programa");
            Console.ReadLine();

        }
    }
}