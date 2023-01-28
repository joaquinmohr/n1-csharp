namespace ejercicio2{

    class Program{

        static void Main(string[] args){

            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            double promedioFinal = 0;
            double promedioParcial, impares, totalGrupo;
            int numero, grupoConMayorPromedio = 0, gruposOrdenados = 0, anterior = -1;
            bool grupoOrdenado;

            for(int x = 0; x < 5; x++){

                impares = 0;
                totalGrupo = 0;
                Console.WriteLine("===============================================================================================");

                numero = Alea();
                //Console.WriteLine("INGRESE NRO");
                //numero = int.Parse(Console.ReadLine());
                anterior = numero;
                grupoOrdenado = true;    //Parto de que estan ordenados

                while(numero != 0){
                    totalGrupo++;   //Cuento ni bien entro

                    //Ordenamiento
                    if(anterior < numero){
                        grupoOrdenado = false;   //Si hubo un anterior menor, es falso que la lista este ordenada
                    }

                    //Tengo que saber si es impar
                        if(!(numero % 2 == 0)){
                            //Es impar
                            //Incremento
                            impares++;
                        }

                    //Muestro el numero en cuestion
                    Console.Write(numero + ", ");

                //Voy actualizando anterior
                anterior = numero;
                numero = Alea();

                //Console.WriteLine("Ingrese un nro");
                //numero = int.Parse(Console.ReadLine());

                }

                Console.WriteLine();

                promedioParcial = impares * 100 / totalGrupo;

                if(impares != 0){
                    Console.WriteLine("El porcentaje del grupo " + (x + 1) + " es: " + promedioParcial.ToString("0.00") + "% con una cantidad de " + impares + " numeros impares sobre " + totalGrupo + " numeros totales");

                    if(grupoOrdenado){
                    Console.WriteLine("El grupo " + (x + 1) + " esta ordenado de mayor a menor");
                    gruposOrdenados++;
                    }else{
                    Console.WriteLine("El grupo " + (x + 1) + " no esta ordenado");
                    }

                }else{
                    Console.WriteLine("Nada que calcular");
                }

                if(promedioParcial > promedioFinal){
                    promedioFinal = promedioParcial;
                    grupoConMayorPromedio = x + 1;
                }

                Console.WriteLine("===============================================================================================");

            }

            Console.WriteLine("El grupo con mayor promedio de numeros impares es el " + grupoConMayorPromedio + " y hay " + gruposOrdenados + " grupos ordenados de mayor a menor");

        }

        static int Alea(){
            Random ran = new Random();
                return ran.Next(0, 10);
        }
    }
}