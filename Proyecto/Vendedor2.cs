using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Vendedor2 : Vendedor, Interfaces.Ivendedor2
    {
        private string nombre;

        public Vendedor2(string nombre)
        {
            this.nombre = nombre;
        }

        public void VentasCredito()
        {
            Console.WriteLine($"El vendedor {nombre} realizó una venta de crédito");
        }
    }
}
