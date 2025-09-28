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

        public void InsertarDato(Cajas info)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = info;

            if (primero == null)
            {
                primero = nuevoDato;
            }
            else
            {
                Nodo temp = primero;

                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoDato;
            }
        }
        public void MostrarDatos()
        {
            Nodo temp = primero;

            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.siguiente;
            }
        }
        public bool BuscarCaja(int codigo)
        {
            Nodo temp = primero;

            while (temp != null)
            {
                if (temp.dato.codigo == codigo)
                {
                    Console.WriteLine(temp.dato);
                    return true;
                } 
                temp = temp.siguiente;
            }
            return false;
        }

    }
}
