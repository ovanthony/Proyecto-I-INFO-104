using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto.Interfaces;

namespace Proyecto
{
    internal class Vendedor1 : Vendedor, Interfaces.Ivendedor1
    {
        private string nombre;

        public Vendedor1(string nombre)
        {
            this.nombre = nombre;
        }

        public void VentasContado()
        {
            Console.WriteLine($"El vendedor {nombre} realizó una venta de contado");
        }
    }
}
