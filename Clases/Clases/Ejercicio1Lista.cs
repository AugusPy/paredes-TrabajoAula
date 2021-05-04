using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Ejercicio1
    {
        

        public void SumaLista()
        {

            List<int> ejer1 = new List<int>();
            
            var num = new Random();

            int sum = 0;
            int prom = 0; 
            for (int i = 0; i < 25; i++)
            {
                var aux = num.Next(0, 101);
                Console.WriteLine("El numero generado es: " + aux);
                sum = sum + aux;
            }

            prom = sum / 25;

            Console.WriteLine($"\nEl valor de la suma de los numeros es: {sum}\n");
            Console.WriteLine($"El promedio es: {prom}");

            
        }

        
    }
}
