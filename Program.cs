using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Ingresos
{
    public static void SumarIngresos()
    {
        // Este es el codigo para pedir el nombre del usuario 
        Console.Write("Introduzca su nombre: ");
        string nombreUsuario = Console.ReadLine();

        // Arreglo para almacenar ingresos
        // Aqui mismo puedes agregar mas meses si modificas el valor de la variable 
        double[] ingresosMeses = new double[3];

        // Aqui se piden los ingresos de cada mes
        for (int i = 0; i < ingresosMeses.Length; i++)
        {
            Console.Write($"Introduzca sus ingresos del mes {i + 1}: ");
            ingresosMeses[i] = double.Parse(Console.ReadLine());
        }

        // Calcular suma total
        double sumaIngresos = 0;
        foreach (double ingreso in ingresosMeses)
        {
            sumaIngresos += ingreso;
        }

        // Calcular promedio
        double promedioIngresos = sumaIngresos / ingresosMeses.Length;

        // Imprimir mensaje con nombre, suma y promedio
        Console.WriteLine($"\nHola {nombreUsuario}, en total ganaste ${sumaIngresos:F2} y promediaste ${promedioIngresos:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ingresos.SumarIngresos();
    }
}
