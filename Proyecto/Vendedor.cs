using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Vendedor
    {
        public Vendedor() { }

        public class Vendedores
        {
            private static Dictionary<string, string> vendedores = new Dictionary<string, string> { { "001", "Pedro Cortés" }, { "002", "María Arguedas" } };

            public static void ListadoVendedores()
            {
                foreach (KeyValuePair<string, string> vendedor in vendedores)
                {
                    Console.WriteLine($"Código: {vendedor.Key}, Nombre: {vendedor.Value}");
                }

            }

            public static string BuscarVendedor(string codigo)
            {
                return vendedores.ContainsKey(codigo) ? vendedores[codigo] : "\n**No se encontró el vendedor, por favor digite un código correcto**";
            }
        }     

    }
}
