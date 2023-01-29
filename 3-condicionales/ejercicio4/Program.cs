
namespace ejercicio4 {

    class Program {

        static void Main(string[] args) {

            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int num, menor;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            menor = num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if(num < menor){
                menor = num;
            }
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if(num < menor){
                menor = num;
            }
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if(num < menor){
                menor = num;
            }
            Console.WriteLine("El menor de los 4 numeros ingresados es " + menor);
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}