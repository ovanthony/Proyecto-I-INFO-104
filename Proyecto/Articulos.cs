using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Articulos
    {
        protected string[] codigos;
        protected string[] nombres;
        protected decimal[] precios;
        public static int cantidad;

        public Articulos()
        {
            codigos = new string[5];
            nombres = new string[5];
            precios = new decimal[5];
            cantidad = 0;
        }

        public string[] Codigos
        {
            get { return codigos; }
            set { codigos = value; }
        }

        public string[] Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public decimal[] Precios
        {
            get { return precios; }
            set { precios = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
        }

        public void AgregarArticulo(string codigo, string nombre, decimal precio)
        {
            if (cantidad < 5)
            {
                codigos[cantidad] = codigo;
                nombres[cantidad] = nombre;
                precios[cantidad] = precio;
                cantidad++;
            }
            else
            {
                throw new InvalidOperationException("\n**Ya se han ingresado 5 artículos, no se guardará el ingresado recientemente.**");
            }
        }

        public int ConsultarArticulo(string codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (codigos[i] == codigo)
                {
                    return i;
                }
            }

            return -1;
        }

        public void BorrarArticulo(string codigo)
        {
            int indice = ConsultarArticulo(codigo);

            if (indice >= 0)
            {
                for (int i = indice; i < cantidad - 1; i++)
                {
                    codigos[i] = codigos[i + 1];
                    nombres[i] = nombres[i + 1];
                    precios[i] = precios[i + 1];
                }

                cantidad--;
            }
            else
            {
                throw new ArgumentException("\nNo se encontró ningún artículo con el código especificado.\n");
            }
        }
    }

}
