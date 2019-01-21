using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImpares
{
    public class OrderRange
    {
        public string build(List<int> listaNumeros)
        {           
            
            string cadenaDevolver = "";           
            var listaPares = new List<int>();
            var listaImPares = new List<int>();                   

            for (int i = 0; i < listaNumeros.Count(); i++)
            {
                if (listaNumeros[i] % 2 == 0)
                {
                    listaPares.Add(listaNumeros[i]);                    
                }
                else
                {
                    listaImPares.Add(listaNumeros[i]);                    
                }               
            }

            if (listaPares.Count()>0)
            {
                listaPares.Sort();
                cadenaDevolver = "[";
                for (int i = 0; i < listaPares.Count(); i++)
                {
                    if (i == listaPares.Count() - 1)
                    {
                        cadenaDevolver = cadenaDevolver + listaPares[i] + "] ";
                    }
                    else
                    {
                        cadenaDevolver = cadenaDevolver + listaPares[i] + ",";
                    }
                }
            }

            if (listaImPares.Count() > 0)
            {
                listaImPares.Sort();
                cadenaDevolver = cadenaDevolver + "[";
                for (int i = 0; i < listaImPares.Count(); i++)
                {
                    if (i == listaImPares.Count() - 1)
                    {
                        cadenaDevolver = cadenaDevolver + listaImPares[i] + "] ";
                    }
                    else
                    {
                        cadenaDevolver = cadenaDevolver + listaImPares[i] + ",";
                    }
                }
            }            

            return cadenaDevolver;

        }

        static void Main(string[] args)
        {
            
            OrderRange objetoPrueba = new OrderRange();
            var ListadoNumeros = new List<int>();            
            Console.WriteLine("Imprimiendo Pares Impares");
            Console.WriteLine(objetoPrueba.build(ListadoNumeros));           
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
