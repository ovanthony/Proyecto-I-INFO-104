using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria3 : Categoria
    {
        public static string desc3 = "Todo a mitad de precio.";
        public override void promocion()
        {
            Console.WriteLine(desc3);
        }
    }
}
