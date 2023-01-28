
namespace ejercicio2{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
            //Solo se debe emitir UN valor por pantalla.

            int nro;
            int max = int.MinValue;
            Console.WriteLine("Minimo valor de un tipo int: " + max);
            int cont = 0;

            do{
                Console.Write("Ingrese un numero: ");
                nro = int.Parse(Console.ReadLine());
                if(nro > max){
                    max = nro;
                }
                cont++;
            }while(cont < 10);




            // Console.Write("Ingrese el primer numero: ");
            // nro = int.Parse(Console.ReadLine());
            // max = nro;
            // Console.WriteLine();

            // for(int i = 0; i < 9; i++){

            //     Console.Write("Ingrese otro: ");
            //     nro = int.Parse(Console.ReadLine());
            //     Console.WriteLine();

            //     if(nro > max){
            //         max = nro;
            //     }
            // }

            Console.WriteLine("El mayor de ellos es: " + max);
        }
    }
}