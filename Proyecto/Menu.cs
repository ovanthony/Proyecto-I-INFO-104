using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Menu
    {
        public static string[] stringCat = new string[5];
        public static string[] stringVen = new string[5];
        public static void Consultar()
        {

            Articulos misArticulos = new Articulos();
            Categoria misCategorias = new Categoria();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menú ===");
                Console.WriteLine("1. Articulos.");
                Console.WriteLine("2. Facturacion.");
                Console.WriteLine("3. Reporte.");
                Console.WriteLine("4. Salir.");
                Console.Write("Ingrese su opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Agregar artículo.");
                            Console.WriteLine("2. Consultar artículo.");
                            Console.WriteLine("3. Borrar artículo.");
                            Console.WriteLine("4. Salir.");

                            Console.Write("Ingrese una opción: ");
                            string opcionStr = Console.ReadLine();


                            if (!int.TryParse(opcionStr, out opcion))
                            {
                                Console.WriteLine("\nOpción inválida. Ingrese un número del 1 al 4.");
                                Console.ReadKey();
                                continue;
                            }

                            Console.WriteLine();

                            switch (opcion)
                            {
                                case 1:
                                    Console.Write("Ingrese el código del artículo: ");
                                    string codigo = Console.ReadLine();

                                    Console.Write("Ingrese el nombre del artículo: ");
                                    string nombre = Console.ReadLine();

                                    Console.Write("Ingrese el precio del artículo: ");
                                    decimal precio = decimal.Parse(Console.ReadLine());

                                    try
                                    {
                                        misArticulos.AgregarArticulo(codigo, nombre, precio);
                                        Console.WriteLine("\nArtículo agregado con éxito.");
                                    }
                                    catch (InvalidOperationException e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Write("Ingrese el código del artículo: ");
                                    string codigoConsulta = Console.ReadLine();

                                    int indice = misArticulos.ConsultarArticulo(codigoConsulta);

                                    if (indice >= 0)
                                    {
                                        Console.WriteLine("Código: {0}", misArticulos.Codigos[indice]);
                                        Console.WriteLine("Nombre: {0}", misArticulos.Nombres[indice]);
                                        Console.WriteLine("Precio: {0}", misArticulos.Precios[indice]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nNo se encontró ningún artículo con el código especificado.\n");
                                    }

                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Write("Ingrese el código del artículo: ");
                                    string codigoBorrado = Console.ReadLine();

                                    try
                                    {
                                        misArticulos.BorrarArticulo(codigoBorrado);
                                        Console.WriteLine("\nArtículo borrado con éxito.");
                                    }
                                    catch (ArgumentException e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.WriteLine("**Volviendo al menú principal**");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida. Ingrese un número del 1 al 4.");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcion != 4);

                        break; //end case1


                    case 2:

                        Console.Clear();
                        Categoria.CategoriaMenu.AsigCat();

                        Console.WriteLine("Por favor ingrese el código del artículo: ");
                        string codigoConsulta2 = Console.ReadLine();

                        int indice2 = misArticulos.ConsultarArticulo(codigoConsulta2);

                        if (indice2 >= 0)
                        {
                            Console.WriteLine("\n=== Detalles del artículo ===");
                            Console.WriteLine("Código: {0}", misArticulos.Codigos[indice2]);
                            Console.WriteLine("Nombre: {0}", misArticulos.Nombres[indice2]);
                            Console.WriteLine("Precio: {0}", misArticulos.Precios[indice2]);

                            Console.WriteLine("\nPor favor ingrese el código del vendedor: ");
                            string codigoVen = Console.ReadLine();

                            if (codigoVen == "001")
                            {
                                Console.WriteLine("\nSeleccionó a " + Vendedor.Vendedores.BuscarVendedor(codigoVen) + ".");
                                stringVen[indice2] = Vendedor.Vendedores.BuscarVendedor(codigoVen);
                            }
                            else
                            {
                                if (codigoVen == "002")
                                {
                                    Console.WriteLine("\nSeleccionó a " + Vendedor.Vendedores.BuscarVendedor(codigoVen) + ".");
                                    stringVen[indice2] = Vendedor.Vendedores.BuscarVendedor(codigoVen);

                                } else
                                {
                                    Console.WriteLine(Vendedor.Vendedores.BuscarVendedor(codigoVen));

                                }

                            }

                            Console.WriteLine("\nPor favor ingrese el tipo de categoría: 0 - 2");
                            int tipo = int.Parse(Console.ReadLine());

                            switch (tipo)
                            {
                                case 0:
                                    Console.WriteLine(Categoria.test[tipo]);
                                    stringCat[indice2] = Categoria.test[tipo].ToString();
                                    break;

                                case 1:
                                    Console.WriteLine(Categoria.test[tipo]);
                                    stringCat[indice2] = Categoria.test[tipo].ToString();
                                    break;

                                case 2:
                                    Console.WriteLine(Categoria.test[tipo]);
                                    stringCat[indice2] = Categoria.test[tipo].ToString();
                                    break;

                                default:
                                    Categoria Buscar = new Categoria();
                                    bool categoriaEncontrada = Categoria.CategoriaMenu.BuscarCategoria(Buscar);

                                    if (!categoriaEncontrada)
                                    {
                                        Console.WriteLine("\nEl tipo de categoría no es correcto, no se asignará al producto.");
                                    }
                                    break;
                            }

                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("\nNo se encontró ningún artículo con el código especificado. Por favor verifique en la sección de artículos.");
                            opcion = 2;
                            Console.ReadKey();
                        }
                        Console.ReadKey();

                        break; //end case2

                    case 3:

                        Console.WriteLine("\n=== Lista de vendedores ===");
                        Vendedor.Vendedores.ListadoVendedores();
                        Console.WriteLine("\n=== Lista de categorías ===");
                        Categoria.CategoriaMenu.ListadoCategorias();
                        Console.WriteLine("\n=== Lista de artículos ===");

                        for (int i = 0; i < Articulos.cantidad; i++)
                        {
                            if (Articulos.cantidad != 0)
                            {
                                Console.WriteLine("\nArtículo [" + i + "]");
                                Console.WriteLine("Código: {0}", misArticulos.Codigos[i]);
                                Console.WriteLine("Nombre: {0}", misArticulos.Nombres[i]);
                                Console.WriteLine("Precio: {0}", misArticulos.Precios[i]);
                                Console.WriteLine("Categoría: {0}", stringCat[i]);
                                Console.WriteLine("Vendedor: {0}", stringVen[i]);
                            }
                        }
                        Console.WriteLine("\n**Presione una tecla para continuar**");
                        Console.ReadKey();
                        break; //end case3 

                    case 4:
                        Console.WriteLine("\n**Saliendo del programa**\n");
                        return; //end case4

                    default:
                        Console.WriteLine("\nOpción inválida. Presione cualquier tecla para continuar.\n");
                        Console.ReadKey();
                        break;
                }

            }



        }






    }// end class
}// namespace
