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

        public void Apilar(Cajas infor)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = infor;

            nuevoDato.siguiente = cima;
            cima = nuevoDato;
        }
        public Cajas Desapilar()
        {
            if (cima != null)
            {
                Cajas  dato = cima.dato;

                cima = cima.siguiente;
                return dato;
            }
            else
            {
                return null;
            }
        }
        public void Clasificaja(ListaEnlazada liviana, ListaEnlazada pesada)
        {
            Nodo temp = cima;
            
            while (temp != null)
            {
                Cajas caja = Desapilar();

                if (caja.peso > 50)
                {
                    pesada.InsertarDato(caja);
                }
                else
                {
                    liviana.InsertarDato(caja);
                }
                temp = temp.siguiente;
            }
            Console.WriteLine("Cajas clasificadas exitosamente");
        }
    }
}
