namespace ejercicio4{

    class Program{

        static void Main(string[] args){

            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            int[] articulos = new int[15];
            int masVendido = 0;

            for(int i = 0; i < 15; i++){

                articulos[i] = Alea();

                if(articulos[i] > masVendido){
                    masVendido = articulos[i];
                }

            }


            Console.Write("a- El articulo que mas se vendio fue el ");
            for(int i = 0; i < 15; i++){

                if(articulos[i] == masVendido){

                    Console.Write((i+1) + ", ");

                }

            }
            Console.Write("\nb- Los articulos n: ");

            for(int i = 0; i < 15; i++){

                //Si no tuvo ventas
                if(articulos[i] == 0){
                    Console.Write((i+1) + ", ");
                }

            }
            Console.Write("no registraron ventas");

            Console.WriteLine("\nc- Del articulo 10 se vendieron " + articulos[9] + " unidades\n");

            //Muestro el arreglo para chequear
            foreach (int i in articulos){
                Console.Write(" " + i);
            }

        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0, 10);
        }
    }
}