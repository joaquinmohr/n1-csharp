namespace ejercicio5{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            //Version1
            int nro, max, min;
            max = int.MinValue;
            min = int.MaxValue;

            //Version2
            int n;
            int maxPar = 0;
            int minImpar = 0;
            bool par = false;
            bool impar = false;

            Console.WriteLine("VERSION1");

            //Version1
            for(int i = 0; i < 20; i++){
                nro = Alea();
                Console.Write(nro + " - ");

                if(nro % 2 == 0){
                    //Par
                    if(nro > max){
                        max = nro;
                    }
                }else{
                    //Impar
                    if(nro < min){
                        min = nro;
                    }
                }
                //Si es par y es mayor que el maximo
                // if((nro % 2 == 0) && nro > max){
                //     //Ahora es mi maximo
                //     max = nro;

                // //Es menor al minimo?
                // }else if (nro < min){
                //     //Ahora es mi minimo
                //     min = nro;
                // }
            }
            Console.WriteLine("\nVERSION2");

            //Version2
            for(int i = 0; i < 20; i++){
                n = Alea();
                Console.Write(n + " - ");

                if(n % 2 == 0){
                    //Me llega un n par
                    //Ya tengo un par?
                    if(!par){
                        //Si no tengo un par
                        maxPar = n;
                        par = true;
                    }else{
                        //Si tengo un par
                        if(n > maxPar){
                            maxPar = n;
                        }
                    }
                }else{
                    //Me llega un n impar
                    //Ya tengo un impar?
                    if(!impar){
                        //Si no tengo un impar
                        minImpar = n;
                        impar = true;
                    }else{
                        //Si tengo un impar
                        if(n < minImpar){
                            minImpar = n;
                        }
                    }
                }
            }

            Console.WriteLine("\nVERSION1 - El maximo de los pares es " + max + " y el minimo de los impares es " + min);
            Console.WriteLine("VERSION2 - El maximo de los pares es " + maxPar + " y el minimo de los impares es " + minImpar);
        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0,100);
        }
    }
}