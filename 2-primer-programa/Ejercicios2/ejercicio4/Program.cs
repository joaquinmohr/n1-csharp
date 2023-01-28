namespace ejercicio4 {

class Program {

    static void Main(string[] args) {

        //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
        //Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
        //Regla de 3
        //Si el 100% es el total facturado, cuanto es el 5?
        //100%  >>  totalFacturado
        //5%    >>  ???
        //porcentajeComision = 5 * totalFacturado / 100;
        //porcentajeComision = totalFacturado * 0.05;
        //porcentajeComision = totalFacturado - totalFacturado * 0.95;

        //Otra forma de calcular porcentajes
        //4500 * 1.21 = 5445    << suma el 21% al monto
        //4500 * 1.35 = 6075    << suma el 35% al monto
        //4500 * 0.21 = 945     << resta el 21% al monto
        //4500 * 0.35 = 1575    << resta el 35% al monto

        Console.WriteLine("Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado.\n" + 
        "Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.\n");

        float totalFacturado, totalNeto;
        const float sueldoFijo = 15000;
        const float porcentajeComision = 5;

        Console.WriteLine("Ingrese el monto facturado por el empleado");
        totalFacturado = float.Parse(Console.ReadLine());

        totalNeto = sueldoFijo + ((totalFacturado/100)*porcentajeComision);

        Console.WriteLine("El empleado este mes cobrara " + totalNeto);

        }
    }
}