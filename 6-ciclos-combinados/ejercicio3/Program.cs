namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int nro, numeros, lista = 0;

            do{

                lista++;
                numeros = 0;
                nro = Alea();
                //nro = int.Parse(Console.ReadLine());

                Console.WriteLine("Lista numero " + lista);

                while(nro > 0){

                    numeros++;
                    nro = Alea();
                    //nro = int.Parse(Console.ReadLine());
                    Console.Write(nro + ", ");

                }

                Console.WriteLine("\nTiene " + numeros + " numeros\n---------------");

            }while(nro >= 0);

            Console.WriteLine("Fin del programa");

        }

        static int Alea(){
            Random ran = new Random();
                return ran.Next(-1, 20);
        }
    }
}
