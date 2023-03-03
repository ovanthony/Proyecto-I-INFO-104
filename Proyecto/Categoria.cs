using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria
    {
        public static string[] test = new string[5];

        public virtual void promocion()
        {
            Console.WriteLine("**Descuentos y promociones**");

        }

        public class CategoriaMenu
        {
            public static List<Categoria> categorias = new List<Categoria>
            {

                new Categoria1(),
                new Categoria2(),
                new Categoria3()

            };

            public static void AsigCat()
            {
                test[0] = Categoria1.desc1;
                test[1] = Categoria2.desc2;
                test[2] = Categoria3.desc3;

            }

            public static void ListadoCategorias()
            {

                foreach (Categoria categoria in categorias)
                {
                    categoria.promocion();
                }


            }

            public static bool BuscarCategoria(Categoria categoria)
            {

                return categorias.Contains(categoria);

            }

        }

    }
}
