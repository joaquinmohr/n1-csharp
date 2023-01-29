
namespace ejercicio2 {

    class Program {

        static void Main(string[] args) {

            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla 
            //“Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

            Console.WriteLine("Hacer un programa para ingresar un número y luego se emita un cartel por pantalla\n" + 
            "“Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o " + 
            "“Cero” si el número es igual a cero.\n");

            int numero;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if(numero == 0){
                Console.WriteLine("Cero");
            }else if(numero > 0){
                Console.WriteLine("Positivo");
            }else{
                Console.WriteLine("Negativo");
            }
            
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}