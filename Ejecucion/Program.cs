using MiBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la operacion a convertir de infija a postfija. ");
            String infija = Console.ReadLine();

            ListaEnlazada salida = new ListaEnlazada();
            Pila operadores = new Pila();

            foreach (char c in infija)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >='0' && c <= '9')) 
                {
                    salida.InsertarDatos(c);
                }
                else if (c == '+' || c == '-' || c == '*' ||  c == '/')
                {
                    operadores.Apilar(c);
                }
                else if(c == '(')
                {
                    operadores.Apilar(c);
                }
                else if (c == ')')
                { 
                    while (operadores.VerCima() != '(')
                    {
                       salida.InsertarDatos(operadores.Desapilar());
                    }
                    operadores.Desapilar();
                }
                
            }
            while (operadores.cima != null)
            {
                salida.InsertarDatos(operadores.Desapilar());
            }

            Console.WriteLine("La expresion en notacion postfija es: ");
            salida.MostrarDatos();
        }
    }
}
