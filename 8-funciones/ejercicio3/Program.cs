namespace ejercicio3{
    
    class Program{

        static void Main(string[] args){

            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            int numero;
            float promedio;
            float acumulador = 0;
            float contador = 0;

            do{
                Console.WriteLine("Ingres un numero para saber si es primo");
                numero = int.Parse(Console.ReadLine());

                if(primo(numero) == 1 && numero != 0){
                    Console.WriteLine("Numero primo");
                    acumulador += numero;
                    contador++;
                }else{
                    Console.WriteLine("NO LO ES");
                }

            }while(numero != 0);

            promedio = acumulador / contador;

            Console.WriteLine("El promedio de los numeros primos ingresados es " + promedio.ToString("0.00"));

        }

        static int primo(int nro){

            int contDivisores = 0;
            for(int i = 2; i < nro; i++){

                if(nro % i == 0){
                    contDivisores++;
                }

            }
            //Si no tuvo mas divisores que 1 y el mismo
            if(contDivisores == 0){
                //Es primo
                return 1;
            }else{
                //No lo es
                return 0;
            }

        }
    }
}