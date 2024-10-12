using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Evaluacion_Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.Write("Ingresa la calificacion: ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"La calificacion es de {calificacion}, aprobado.");
            }
            else if (calificacion >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificacion es de {calificacion}, reprobado con derecho a regularizacion.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificacion es de {calificacion}, reprobado debe volver a cursar.");
            }


            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
