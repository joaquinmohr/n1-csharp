namespace ejercicio4{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite UN número y 
            //luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int primo;
            int cant = 0;
            Console.WriteLine("Ingrese hasta que numero desea saber si es primo: ");
            primo = int.Parse(Console.ReadLine());

            for(int x = 0; x <= primo; x++){
                if(Primo(x)){
                    Console.WriteLine("El numero " + x + " es primo");
                    cant++;
                }
            }
            
            Console.WriteLine("Desde el 0 al " + primo + " hay " + cant + " numeros primos");
        }

        //Funcion para calcular si un numero es primo
        static bool Primo(int nro){
            int cont = 0;
            for(int i = 1; i <= nro; i++){
                if(nro % i == 0){
                    cont++;
                }
            }
                if(cont == 2){
                    return true;
                }else{
                    return false;
                }
        }
    }
}