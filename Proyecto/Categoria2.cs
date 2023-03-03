using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria2 : Categoria
    {
        public static string desc2 = "Promoción dos por 1.";
        public override void promocion()
        {
            Console.WriteLine(desc2);
        }
    }
}
