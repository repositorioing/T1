using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Cajas
    {
        public int codigo;
        public string descripcion;
        public float peso;

        public Cajas(int codigo, string descripcion, float peso)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.peso = peso;
        }

        public override string ToString()
        {
            return $"Codigo: {codigo}\nDescripcion: {descripcion}\nPeso: {peso}";
        }
        
    }
}
