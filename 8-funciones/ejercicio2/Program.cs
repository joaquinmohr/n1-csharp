namespace ejercicio2{

    class Program{

        static void Main(string[] args){

            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int nro;
            int cont = 0;

            int ind = 0;
            while(ind < 20){

                nro = alea();

                //Si la funcion par mandandole el nro me devuelve 1
                if(par(nro) == 1){
                    //Lo cuento como par
                    cont++;
                }

                ind++;
            }

            //Muestro cuantos son pares
            Console.WriteLine("En esta ejecucion hubo " + cont + " numeros pares");

        }

        static int par(int n){
            int r;
            if(n % 2 == 0){
                r = 1;
            }else{
                r = 0;
            }
            return r;
        }

        static int alea(){
            Random ran = new Random();
            return ran.Next(0, 1000);
        }
    }
}