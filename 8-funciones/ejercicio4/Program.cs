namespace ejercicio4{

    class Program{

        static void Main(string[] args){

            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            //Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            int z = 0;
            int nro;

            nro = alea();

            positivoNegativoCero(nro, ref z);

            Console.WriteLine("El valor de z es " + z);


        }

        static void positivoNegativoCero(int nro, ref int n){

            if(nro > 0){
                n = 1;
            }else if(nro < 0){
                n = -1;
            }else{
                n = 0;
            }

        }

        static int alea(){
            Random ran = new Random();
            return ran.Next(-50, 50);
        }
    }
}