using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class ListaEnlazada
    {
        public Nodo primero = null;

        public void InsertarDatos(char operador)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = operador;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;

                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevo;
            }

        }
        public void MostrarDatos()
        {
            Nodo temp = primero;

            while (temp != null)
            {
                Console.Write(temp.dato);
                temp = temp.siguiente;  
            }
            Console.WriteLine();
        }
        

    }
}
