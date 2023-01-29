namespace TPFinal_Mohr{

    class Program{

        static void Main(string[] args){

            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int nro;
            int maxPares = 0;
            int minPrimos = 0;
            int cantImpares = 0;
            bool tengoPrimo = false;
            bool tengoPar = false;

            do{

                Console.WriteLine("Ingrese un numero: ");
                nro = int.Parse(Console.ReadLine());

                //Si es par y aun no tengo pares
                if(esPar(nro) && !tengoPar && nro > 0){
                    maxPares = nro;     //Es el mas grande que tengo hasta ahora
                    tengoPar = true;    //Cambio el valor

                    //Si es par y es mayor al mas grande que tengo
                }else if(esPar(nro) && nro > maxPares && nro > 0){
                    maxPares = nro;     //Ahora es el mas grande
                }else{
                    //Si no fijate si es impar y contamelo
                    contImpar(nro, ref cantImpares);
                }


                //Si es primo y aun no tengo primos
                if(esPrimo(nro) && !tengoPrimo && nro > 1){
                    minPrimos = nro;    //Es el mas chico que tengo hasta ahora
                    tengoPrimo = true;  //Cambio el valor

                    //Si es primo y es menor al mas chico que tengo
                }else if(esPrimo(nro) && nro < minPrimos && nro > 1){
                    minPrimos = nro;    //Ahora es el mas chico
                }

            }while(nro != 0);

            Console.WriteLine("Mayor de los numeros pares: " + maxPares);
            Console.WriteLine("Cantidad de numeros impares: " + cantImpares);
            Console.WriteLine("Menor de los numeros primos: " + minPrimos);


        }

        //Contador de impares
        static void contImpar(int nro, ref int impar){

            if(!(nro % 2 == 0)){
                impar++;
            }

        }
        //Numero par?
        static bool esPar(int nro){

            if(nro % 2 == 0){
                return true;
            }else{
                return false;
            }

        }
        //Es primo?
        static bool esPrimo(int nro){

            int divisor = 0;
            //for despreciando el 1 y el mismo nro
            for(int i = 2; i < nro; i++){
                if(nro % i == 0){
                    divisor++;
                }
            }
            //Si no tuvo ningun otro divisor
            if(divisor == 0){
                //Es primo
                return true;
            }else{
                //No lo es
                return false;
            }
        }
    }
}