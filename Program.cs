using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 32. Solicitar el ingreso de dos fechas al usuario y determine el intervalo
             de días, meses y años*/
            string fecha1;
            string fecha2;
            DateTime salidaFecha1 = DateTime.Now;
            DateTime salidaFecha2 = DateTime.Now;
            TimeSpan intervalo;

            do
            {
                Console.WriteLine("Ingrese 2 fechas");
                fecha1 = Console.ReadLine();
                fecha2 = Console.ReadLine();
                bool flag = ValidarFecha(fecha1, salidaFecha1);
                bool flag2 = ValidarFecha(fecha2,salidaFecha2);
                intervalo = salidaFecha2 - salidaFecha1;
               
                Console.WriteLine($"Las fechas ingresadas son {salidaFecha1} y {salidaFecha2}");
                Console.WriteLine($"El intervalo de dias es {intervalo.Days}");
                Console.WriteLine($"El intervalo de meses es {intervalo.Month}");
                Console.WriteLine($"El intervalo de año es de {intervalo.Year} ");
            } while (true);           
           
        }

        private static bool ValidarFecha(string fecha, DateTime salida)
        {
            bool flag = false;
            Console.WriteLine("Ingrese una fecha");
            fecha = Console.ReadLine();
            if (!DateTime.TryParse(fecha, out salida))
            {
                Console.WriteLine("Usted no ha ingresado una fecha");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
