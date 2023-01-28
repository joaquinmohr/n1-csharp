namespace ejercicio2{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] enteros = new int[10];
            int prom;
            int cont = 0;
            int cant = 0;

            for(int i = 0; i < 10; i++){

                enteros[i] = Alea();
                cant += enteros[i];
                cont++;

            }

            prom = cant / cont;
            
            cont = 0;

            //Muestro promedio
            Console.WriteLine("El promedio del vector en esta ejecucion es " + prom + "\n");

            for(int i = 0; i < 10; i++){

                if(enteros[i] > prom){
                    Console.WriteLine("El valor " + enteros[i] + " en la posicion " + i + " del vector es mayor al promedio");
                    cont++;
                }

            }

            Console.WriteLine("\nHay " + cont + " valores mayores al promedio\n");

            //Muestro el vector completo para chequear
            for(int i = 0; i < 10; i++){

                Console.Write(" " + enteros[i]);

            }



        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0, 1000);
        }
    }
}