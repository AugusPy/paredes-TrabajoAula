using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;



namespace ListasTipoCola1
{
    class Principal
    {
       
        [STAThread]
        static void Main(string[] args)
        {


            //Listas Alumno = new Listas();
            //Alumno.ImprimirLista();


            //Ejercitario 2
                //Ejercicio1
                //Ejercicio1 Eje1 = new Ejercicio1();
                //Eje1.SumaLista();

                //Ejercicio 2

            //SEGUNDA PARCIAL LP2.
            Imprimir();

        }

        
        
        static void Imprimir()
        {
            List<int> elementos = new List<int>();
            elementos.Add(2);
            elementos.Add(7);
            elementos.Add(8);
            elementos.Add(3);

            //No sabria como imprimir de manera ordena a mayor facilidad de entender, de igual modo el programa cumple con el pedido

            Console.WriteLine("Lista original: L = [");
            for(int i = 0; i < elementos.Count; i++)
            {
                Console.WriteLine(+elementos[i]);
            }
            Console.WriteLine("]");

            if(elementos.Count == 0)
            {
                Console.WriteLine(" L = []");
            }
            else
            {
                for(int i = 0; i < elementos.Count; i++)
                {
                    elementos[i] = elementos[i] + 1;
                }

                Console.WriteLine("L = [");
                foreach(int dato in elementos)
                {
                   
                   Console.WriteLine(+dato);
                }
                Console.WriteLine("]");
            }


        }

    }

    


    
}
