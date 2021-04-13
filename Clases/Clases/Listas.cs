using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Listas
    {
        static void ImprimirLista()
        {
            string profe = "Andrea";

            List<string> listaAlumnos = new List<string>();

            listaAlumnos.Add("Augusto");
            listaAlumnos.Add("Meli");
            listaAlumnos.Add("Edgar");
            listaAlumnos.Add(profe);

            Console.WriteLine(listaAlumnos[1]);

            foreach (string alumno in listaAlumnos)     //foreach significa para cada elemento
            {
                Console.WriteLine(alumno);
            }

            int contador = 0;
            foreach (string alumno in listaAlumnos)
            {
                Console.WriteLine("Elemento #{" + contador + "}-->" + alumno);
                contador++;
            }
        }
    }
}
