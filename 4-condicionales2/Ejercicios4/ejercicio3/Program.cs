
namespace ejercicio3 {

    class Program {

        static void Main(string[] args) {

            //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            //i5 (1)	i7 (2)	i9 (3)
            //8 RAM (1)	USD 800	USD 900	USD 1200
            //16 RAM (2)	USD 900	USD 1000	USD 1400
            //32 RAM (3)	USD 1000	USD 1400	USD 2000
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea
            //lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador,
            //la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender o 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

            int procesador, memoria, disco, monto = 0;

            Console.WriteLine("Seleccione el procesador\n1- i5\n2- i7\n3- i9");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la memoria\n1- 8gb\n2- 16gb\n3- 32gb");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea expandir el almacenamiento?\n0- no\n1- si");
            disco = int.Parse(Console.ReadLine());

            switch(procesador){
                case 1:
                //i5
                    switch(memoria){
                        case 1:
                        //8gb
                        monto = 800;
                        break;
                        case 2:
                        //16gb
                        monto = 900;
                        break;
                        case 3:
                        //32gb
                        monto = 1000;
                        break;
                        default:
                        //nada
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                break;
                case 2:
                //i7
                    switch(memoria){
                        case 1:
                        //8gb
                        monto = 900;
                        break;
                        case 2:
                        //16gb
                        monto = 1000;
                        break;
                        case 3:
                        //32gb
                        monto = 1400;
                        break;
                        default:
                        //nada
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                break;
                case 3:
                //i9
                    switch(memoria){
                        case 1:
                        //8gb
                        monto = 1200;
                        break;
                        case 2:
                        //16gb
                        monto = 1400;
                        break;
                        case 3:
                        //32gb
                        monto = 2000;
                        break;
                        default:
                        //nada
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                break;
                default:
                //nada
                Console.WriteLine("Opcion incorrecta");
                break;
            }

            if(disco == 1 && monto != 0){
                monto += 300;
            }

            Console.WriteLine(monto != 0 ? "Su pc vale " + monto : "Error Garrafal");
        }
    }
}