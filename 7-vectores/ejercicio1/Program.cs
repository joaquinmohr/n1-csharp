namespace ejercicio1{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] vector = new int[10];
            int max = -1;
            int pos = -1;

            for (int i = 0; i < 10; i++){
                vector[i] = Alea();
            }

            for (int i = 0; i < 10; i++){

                if(vector[i] == 0){
                    max = vector[i];
                    pos = i+1;
                }else if(vector[i] > max){
                    max = vector[i];
                    pos = i+1;
                }
            }

            Console.WriteLine("El valor maximo dentro del vector es " + max + " y se encuentra en la posicion " + pos);
        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0, 10000);
        }
    }

}