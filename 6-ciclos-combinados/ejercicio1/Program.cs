namespace ejercicio1{

    class Program{

        static void Main(string[] args){

            //Hacer un programa para ingresar 10 números. 
            //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int nro, divisores;
            int primo = 0;

            for(int x = 0; x < 10; x++){

                //Pido un numero
                nro = Alea();
                
                //Inicializo divisores en 0 ni bien entro al ciclo
                divisores = 0;

                //Despreciando el 1 y nro (todo primo es divisible por uno y por si mismo)
                for(int y = 2; y < nro; y++){

                    //Si el numero modulo la iteracion en la que se encuentre me da resto cero
                    if(nro % y == 0){
                        //Encontre un divisor que no es 1 ni el mismo
                        divisores++;
                    }
                }
                        //Si no hubo divisores
                        if(divisores == 0){
                            //Es primo
                            Console.WriteLine("El numero " + nro + " es primo");
                            //Lo cuento
                            primo++;
                        }else{
                            //No es primo
                            Console.WriteLine(nro + " no es primo");
                        }

            }
            Console.WriteLine("En esta ejecucion hubo " + primo + " numeros primos");
        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0, 1000);
        }
    }
}