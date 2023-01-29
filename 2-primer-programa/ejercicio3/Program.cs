
namespace ejercicio3 {

class Program {

    static void Main(string[] args) {

        //Consigna: Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
        //Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

        Console.WriteLine("Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.\n" + 
        "Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.\n");

        float distancia, velocidad, tiempo, horas, minutos;
        Console.WriteLine("Ingrese la distancia entre ciudades");
        distancia = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad del vehiculo");
        velocidad = float.Parse(Console.ReadLine());

        tiempo = distancia / velocidad;
        minutos = (tiempo % 1)*60;

        horas = (float)Math.Truncate(tiempo);
        minutos = (float)Math.Truncate(minutos);        

        Console.WriteLine("Para recorrer " + distancia + "km" + " con velocidad constante de " + velocidad + "km/h usted tardara " + horas +":" + minutos + "h");

        }
    }
}