using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria1 : Categoria
    {
        public static string desc1 = "Descuento de 15%.";
        public override void promocion()
        {
            
            Console.WriteLine(desc1);

        }

    }
}
