using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_de_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int numero;

            List<string> Lista = new List<string>();
            palabra = Console.ReadLine();

            while (palabra != "")
            {
                Lista.Add(palabra);
                Console.ReadLine();

            }
            Console.WriteLine("ingrese la pocision de la palabra que quiere");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("ingresa la ñpocicsion de la palabra que desea");
                    numero = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("execede la cantidad de elementos");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }

            //bool verdad = true;
            //string Vacio = "";
            //ArrayList Lista = new ArrayList();
            //while (verdad)
            //{
            //    Console.WriteLine("Ingresa un dato alfanúmerico");
            //    string Dato = Console.ReadLine();
            //    if (Dato == Vacio)
            //    {
            //        verdad = false;
            //    }
            //    else
            //    {
            //        Lista.Add(Dato);
            //    }
            //}
            //for (int i = 0; i < Lista.Count; i++)
            //{
            //    string dato = (string)Lista[i];
            //    Console.WriteLine(dato);
            //}
        }
    }
}

        
    

