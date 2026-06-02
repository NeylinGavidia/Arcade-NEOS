using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1;
using Game2;
using Game3; 
using Game4;
using Game5;

namespace Arcade_NEOS
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //OLVIDENLO YA SE QUE HACER PERO IGUAL EN SU CLASE INDIQUEN EL NUMERO PARA QUE NO SE PIERDAN AL LLAMAR A LA CLASE

            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("********MENU*********");
                Console.WriteLine();
                Console.WriteLine("1. JUEGO 1 (NAT)");
                Console.WriteLine("2. JUEGO 2 (LUZ)");
                Console.WriteLine("3. JUEGO 3 (JHERSON)");
                Console.WriteLine("4. JUEGO 4 (ANDERSON)");
                Console.WriteLine("5. JUEGO 5 (YO)");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.WriteLine("**********************");
                Console.Write("Ingrese una opcion: ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("Goodbye ¬^^¬");
                            break;
                        case 1:
                           
                            break;
                        case 2:
                           
                            break;
                        case 3:
                           
                            break;
                        case 4:

                            break;
                        case 5:

                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    Console.ReadKey();


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e);
                    op = 1;
                }

            }
            while (op != 0);
        }
    }
}
