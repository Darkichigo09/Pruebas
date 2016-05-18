using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static int seleccion = 0;
        static int option = 0;
        static double precio = 0;

        static void Offers()
        {
            Console.Clear();
            Console.WriteLine("Seleccione uno..");
            Console.WriteLine("1.Pantalla LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa");
            seleccion = int.Parse(Console.ReadLine());
            if (seleccion == 1)
            {
                Console.WriteLine("¢325,000.00");
                Console.WriteLine("¢410,000.00");
            }
            else
            {
                Console.WriteLine("No tenemos ofertas");
            }
            //Agregar más ofertas
            Console.ReadKey();
        }
        //Sobrecarga oferta individual


        static int Main() //void
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Almacén Gutierrez");
                Console.WriteLine("1. Evaluar otros comercios.");
                Console.WriteLine("2. Ver clasificación de artículos.");
                Console.WriteLine("3. Ver Ofertas.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        //Salir
                        break;
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione uno..");
                            Console.WriteLine("1.Pantalla LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa\n4.Radiograbadora5.Reproducotr Blueray\n6.Pantalla LCD PC\n7.Consola de mesa\n8.Consola Portatil\n9.Camara Fotografica\n10.Camara de Vigilancia");
                            seleccion = int.Parse(Console.ReadLine());
                            Console.Write("Digite el precio visto:");
                            precio = int.Parse(Console.ReadLine());
                            if (seleccion == 1 && precio < 300000)
                            {
                                Console.WriteLine("Precio muy barato..pero se lo podemos mejorar");
                            }
                            if (seleccion ==1  && precio > 300000 && precio< 600000)
                            {
                                Console.WriteLine("Precio barato...");
                            }
                            if (seleccion == 1 && precio==600000)
                            {
                                Console.WriteLine("Precio Normal");
                            }
                            if (seleccion == 1 && precio > 600000 && precio < 900000)
                            {
                                Console.WriteLine("Precio Caro");
                            }
                            if (seleccion == 1 && precio > 900000)
                            {
                                Console.WriteLine("Precio muy caro...");
                            }
                            if (seleccion == 2 && precio > 200000) {
                                Console.WriteLine("Precio Muy barato");
                            }
                            if (seleccion == 2 && precio > 600000)
                            {
                                Console.WriteLine("Precio Muy caro");
                            }
                            if (seleccion == 3 && precio > 100000)
                            {
                                Console.WriteLine("Precio Muy barato");
                            }
                            if (seleccion == 3 && precio > 300000)
                            {
                                Console.WriteLine("Precio Muy caro");
                            }
                            else
                            {
                                Console.WriteLine("No se tiene clasificación");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione uno..");
                            Console.WriteLine("1.Pantalla TV LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa\n4.Radiograbadora\n5.Reproducotr Blueray\n6.Pantalla LCD PC\n7.Consola de mesa\n8.Consola Portatil\n9.Camara Fotografica\n10.Camara de Vigilancia");
                            seleccion = int.Parse(Console.ReadLine());
         
                            if (seleccion == 3 || seleccion == 1 || seleccion == 4 || seleccion == 5 || seleccion == 6 || seleccion == 7 || seleccion == 8 || seleccion == 9 || seleccion == 10)
                            {
                                Console.WriteLine("Video");
                            }
                            if (seleccion == 2 || seleccion == 4)
                            {
                                Console.WriteLine("Audio");
                            }

                            Console.ReadKey();


                            /*Agregar y clasificar                              
                             * Minicomponente
                             * Reproductor BluRay
                             * Pantalla LCD PC 
                             * Consola de mesa 
                             * Consola portátil  
                             * Cámara fotográfica
                             * Cámara de vigilancia*/
                            break;
                        }
                    case 3:
                        {
                            Offers();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (option != 0);
            return 0;
        }
    }
}
