namespace ejercicio3{

    class Program{

        static void Main(string[] args){

            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            //Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadena = new char[30];
            char c1, c2;
            int indice = 0;

            //Pido la cadena
            Console.WriteLine("Ingrese el texto, punto ('.') para finalizar)");

            c1 = char.Parse(Console.ReadLine());

            while(c1 != '.' && indice < 29){

                cadena[indice] = c1;

                c1 = char.Parse(Console.ReadLine());
                
                indice++;
            }

            //Fin de la cadena
            cadena[indice] = '\0';

            //Apunto al principio
            indice = 0;

            //Pido caracter a reemplazar y caracter de reemplazo
            Console.WriteLine("Ingrese el caracter a reemplazar");
            c1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el caracter de reemplazo");
            c2 = char.Parse(Console.ReadLine());

            //Recorro el vector
            while(cadena[indice] != '\0'){

                if(cadena[indice] == c1){

                    //Reemplazo
                    cadena[indice] = c2;

                }

                indice++;
            }

            //Apunto al principio
            indice = 0;

            //Muestro la cadena reemplazada
            Console.WriteLine("Cadena resultado ");
            while(cadena[indice] != '\0'){

                Console.Write(cadena[indice]);

                indice++;
            }

        }
    }
}