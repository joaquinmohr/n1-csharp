
namespace ejercicio3{

    class Program{

        static void Main(string[] args){

            //Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

            double importe, total, descuento;

            Console.WriteLine("Ingrese el importe de venta");
            importe = double.Parse(Console.ReadLine());
            descuento = 0;
            total = 0;

            if(importe >= 5000){
                descuento = (importe/100) * 18;
                    total = importe - descuento;
            }else if(importe >= 1000){
                descuento = (importe/100) * 10;
                        total = importe - descuento;
            }else{
                total = importe;
            }

            Console.WriteLine("Usted debe pagar " + total.ToString("0.00") + "ARS\nSe le hizo un descuento de " + descuento.ToString("0.00") + "ARS en su compra");
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}