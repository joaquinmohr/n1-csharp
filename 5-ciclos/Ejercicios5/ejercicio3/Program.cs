namespace ejercicio3{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            //20 edades => uso ciclo exacto

            int edad, promedio;
            int acu = 0;
            int con = 0;

            for(int i = 0; i < 20; i++){

                edad = Alea();

                if(edad >= 18){
                    acu += edad;
                    con++;
                }

            }

            promedio = acu / con;

            Console.WriteLine("Hay " + con + " edades mayores a 18 y el promedio de las mismas es " + promedio);
        }

        static int Alea(){
            Random ran = new Random();
            return ran.Next(0,100);
        }
    }
}