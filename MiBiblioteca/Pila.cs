using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Pila
    {
        public Nodo cima = null;

        public void Apilar(char operadores)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = operadores;

            nuevoDato.siguiente = cima;
            cima = nuevoDato;

        }
        public char Desapilar()
        {
            if (cima != null)
            {
                char nuevo = cima.dato;

                cima = cima.siguiente;
                return nuevo;
            }
            else
            {
                return ' ';
            }
        }
        public char VerCima()
        {
            if (cima != null)
            {
                return cima.dato;
            }
            return ' ';
        }
        public bool EstaVacia()
        {
            return cima == null;
        }   


    }
}
