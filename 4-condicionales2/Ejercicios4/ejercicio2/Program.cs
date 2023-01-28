
namespace ejercicio2 {

    class Program {

        static void Main(string[] args) {

            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

            float importe, litros;
            int descuento = 0;

            Console.WriteLine("Ingrese el importe de la venta");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros de la venta");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500){
                importe = importe * 0.75F;
                descuento = 25;
            }
            else if(litros > 300){
                importe = importe * 0.85F;
                descuento = 15;
            }
            else if(litros > 100){
                importe = importe * 0.90F;
                descuento = 10;
            }

            Console.WriteLine("El cliente debe pagar " + importe + " por la compra de " + litros + "lts de liquido desinfectante");
            if(descuento != 0){
                Console.WriteLine("Se aplico un " + descuento + "% de descuento");
            }else{
                Console.WriteLine("No se aplica descuento");
            }

        }
    }
}