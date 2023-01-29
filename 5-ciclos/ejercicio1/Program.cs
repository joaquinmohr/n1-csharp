namespace ejercicio1{

    class Program{

        static void Main(string[] args){

            //Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

            int nro = 1;
            int cont = 0;

            while(nro <= 10){
                Console.WriteLine("Numero " + nro);
                nro++;
            }

            Console.WriteLine();

            while(cont < 10){
                cont++;
                Console.WriteLine("Number " + cont);
            }
        }
    }
}