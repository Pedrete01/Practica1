
using System;
using System.Runtime.Intrinsics.X86;

namespace Practica1
{
    public class Program
    {
        public static void Main()
        {
            cadena();
        }

        public static void cadena()
        {
            string aux = "s";
            do
            {
                Console.WriteLine("Introduce una cadena de al menos 40 caracteres: ");
                string cadena = Console.ReadLine();
                bool correcto = false;

                if (cadena != null)
                {
                    if (cadena.Length >= 40)
                    {
                        Console.WriteLine("\nLa cadena es correcta\n");
                        correcto = true;
                    }
                    else
                    {
                        int falta = 40 - cadena.Length;
                        Console.WriteLine("\nLa cadena tiene " + cadena.Length + ". Necesita " + falta + " caracteres más\n");
                        correcto = false;
                    }
                }

                if (correcto)
                {
                    Console.WriteLine("\n----------------------------------------");
                    Console.WriteLine("OPCIONES: \n");
                    Console.WriteLine("1 - Sustituir palabra ");
                    Console.WriteLine("2 - Buscar texto ");
                    Console.WriteLine("3 - Buscar texto de inicio");
                    Console.WriteLine("0 - Salir ");
                    Console.WriteLine("----------------------------------------\n");

                    Console.WriteLine("Selecciona una opción: ");
                    int opciones = Int32.Parse(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            sustituirPalabra(cadena);
                            break;
                        case 2:
                            buscarPalabra(cadena);
                            break;
                        case 3:
                            buscarPalabraInicio(cadena);
                            break;
                        default:
                            Console.WriteLine("De acuerdo.\n");
                            break;
                    }
                }

                Console.WriteLine("¿Deseas volver a repetirlo? (s/n)");
                aux = Console.ReadLine();

            } while (aux != null && aux == "s");
        }

        public static void sustituirPalabra(string cad)
        {
            Console.WriteLine("Introduce la palabra a sustituir y la palabra que se quiere añadir:");
            Console.WriteLine("(Separadas por un espacio)\n");

            string palabras = Console.ReadLine();

            if (palabras != null && palabras.Length > 0)
            {
                string[] palabra = palabras.Split(' ');
                if (palabra.Length > 1 && palabra[0] != null && palabra[1] != null)
                {
                    string cadenaFinal = cad.Replace(palabra[0], palabra[1]);

                    Console.WriteLine("\nLa cadena original: \n");
                    Console.WriteLine(cad + "\n");
                    Console.WriteLine("La cadena con la sustitución: \n");
                    Console.WriteLine(cadenaFinal + "\n");
                }
                else
                {
                    Console.WriteLine("\nHa ocurrido un error.\n");
                }
            }
        }

        public static void buscarPalabra(string cad)
        {
            Console.WriteLine("Introduce la palabra a buscar:\n");

            string palabra = Console.ReadLine();

            if(palabra != null && palabra.Length > 0)
            {
                
                if(cad.Contains(palabra) == true)
                {
                    Console.WriteLine("\nLa palabra introducida EXISTE.\n");
                }
                else
                {
                    Console.WriteLine("\nLa palabra introducida NO EXISTE.\n");
                }
            }
        }

        public static void buscarPalabraInicio(string cad)
        {
            Console.WriteLine("Introduce la palabra a buscar:\n");

            string palabra = Console.ReadLine();

            if (palabra != null && palabra.Length > 0)
            {

                if (cad.StartsWith(palabra) == true)
                {
                    Console.WriteLine("\nLa cadena comienza con la palabra introducida.\n");
                }
                else
                {
                    Console.WriteLine("\nLa cadena NO comienza con la palabra introducida.\n");
                }
            }
        }
    }
}
