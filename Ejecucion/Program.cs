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
            Pila pila = new Pila();
            ListaEnlazada liviana = new ListaEnlazada();
            ListaEnlazada pesada = new ListaEnlazada(); 

            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("Opcion 1: Registrar caja de llegada:");
                Console.WriteLine("Opcion 2: Clasificar cajas:");
                Console.WriteLine("Opcion 3: Mostrar cajas livianas:");
                Console.WriteLine("Opcion 4: Mostar cajas pesadas:");
                Console.WriteLine("Opcion 5: Buscar caja por codigo:");
                Console.WriteLine("Opcion 6: Mostrar toda la lista:");
                Console.WriteLine("Opcion 0: ======= SALIR =======");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el codigo de la caja: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la descripcion de la caja: ");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Ingresa el peso de la caja: ");
                        float peso = float.Parse(Console.ReadLine());
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        Cajas nuevasCajas = new Cajas(codigo, descripcion, peso);
                        pila.Apilar(nuevasCajas);
                        Console.WriteLine("~~~~~~~~ Caja registrada ~~~~~~~~");
                        break;
                    case 2:
                        pila.Clasificaja(liviana, pesada);
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("CAJAS LIVIANAS");
                        liviana.MostrarDatos();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("CAJAS PESADAS");
                        pesada.MostrarDatos();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        
                        break;
                    case 5:
                        Console.WriteLine("Ingresa el codigo de la caja a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());

                        bool buscarLiviana = liviana.BuscarCaja(buscar);
                        bool buscarPesada = pesada.BuscarCaja(buscar);

                        if (buscarLiviana || buscarPesada)
                        {
                            Console.WriteLine($"La caja con codigo {buscar} fue encontrada.");
                        }
                        else
                        {
                            Console.WriteLine($"La caja con codigo {buscar} no fue encontrada.");
                        }
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("=== TOTAL DE CAJAS REGISTRADAS ===");
                        liviana.MostrarDatos();
                        pesada.MostrarDatos();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("SALIENDO ......");
                        Thread.Sleep(500);
                        Console.WriteLine("SALIENDO ......");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
            }
            while (opcion != 0);
        }
    }
}
