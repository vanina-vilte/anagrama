using System;
using System.Collections.Generic;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeFechas = almacenarFechas();
            List<string> fechasInvertidas = invirtiendoFechas(listaDeFechas);

            Console.WriteLine("Esta es la fecha ingresada");
            mostrarLista(listaDeFechas);
            Console.WriteLine("Esta es la fecha invertida");
            mostrarLista(fechasInvertidas);

        }
        
        static List<string> almacenarFechas()
        {
            string auxiliar = "s";
            List<string> listaDeFechas = new List<string>();
            while (auxiliar == "s")
            {
                Console.WriteLine("Ingrese una fecha porfavor");
                string fechas = Console.ReadLine();
                if (fechas.Length == 10)
                {
                    listaDeFechas.Add(fechas);
                }
                else
                {
                    Console.WriteLine("La fecha que ingresó es invalida");
                }

                Console.WriteLine("Desea continuar con la carga de fecha? Seleccione s para continuar");
                auxiliar = Console.ReadLine();
            }

            return listaDeFechas;
        }

        static string transformarFecha(string fechaIngresada)
        {
            string dia = fechaIngresada.Substring(0, 2);
            string mes = fechaIngresada.Substring(3, 2);
            string año = fechaIngresada.Substring(6, 4);

            return mes + "/" + dia + "/" + año;
        }

        static List<string> invirtiendoFechas(List<string> lista)
        {
            List<string> nuevaListaInvertida = new List<string>();
            foreach (string fecha in lista)
            {
                nuevaListaInvertida.Add(transformarFecha(fecha));
            }

            return nuevaListaInvertida;
        }

        static void mostrarLista (List<string> lista)
        {
            foreach (string elementoDeLista in lista)
            {
                Console.WriteLine(elementoDeLista);
            }
        }
    }
}
