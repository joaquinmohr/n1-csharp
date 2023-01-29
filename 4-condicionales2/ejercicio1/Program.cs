
namespace ejercicio1 {

    class Program {

        static void Main(string[] args) {

            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                resultado = n1 - n2;
                Console.Write("Operacion: resta ");
            }else if(n1 == n2){
                resultado = n1 + n2;
                Console.Write("Operacion: suma ");
            }else{
                resultado = n1 * n2;
                Console.Write("Operacion: multiplicacion ");
            }

            Console.WriteLine("ya que el primer numero es " + n1 + " y el segundo " + n2 + " el resultado es " + resultado);

        }
    }
}