using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    public class PokeDemo
    {
        private Arbol5 arbol = new Arbol5();
        private Random rnd = new Random();

        private string player;
        private Pokemon pjugador;
        private Pokemon prival;
        string atqp;
        string atqr;

        public void Iniciar()
        {
            CargarPokemon();
            Intro();
            ElegirPokemon();
            ElegirRival();
            Batalla();
            Final();
        }

        private void Intro()
        {
            Console.WriteLine("<----------- CARGANDO EL JUEGO *-* ----------->");
            Console.WriteLine();
            Console.WriteLine("Hola, bienvenido/a al pueblo Paleta.");
            Console.WriteLine("Soy el profesor Oak.");
            Console.WriteLine();

            Console.Write("Cuéntame sobre ti, ¿cuál es tu nombre?: ");
            player = Console.ReadLine();

            Console.WriteLine($"\nHola, {player}");
            Console.WriteLine("Profesor Oak: Hoy elegirás un Pokémon que te acompañará en tus aventuras.");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        private void CargarPokemon()
        {
            arbol.Insertar(new Pokemon("Bulbasaur", "Planta", 10, 10, 20));
            arbol.Insertar(new Pokemon("Squirtle", "Agua", 9, 12, 20));
            arbol.Insertar(new Pokemon("Charmander", "Fuego", 12, 8, 20));
        }

        private void ElegirPokemon()
        {
            int pok;

            do
            {
                Console.WriteLine("Elige tu Pokémon:");
                arbol.Mostrar();

                Console.Write("Código: ");
                pok = int.Parse(Console.ReadLine());

                pjugador = arbol.Buscar(pok);

                if (pjugador == null)
                {
                    Console.WriteLine("Código no válido.");
                }
                else
                {
                    if (pok == 1 || pok == 2)
                    {
                        atqp = "Placaje";
                    }
                    else if (pok == 3)
                    {
                        atqp = "Arañazo";
                    }

                    break;
                }

            } while (pjugador == null);

            Console.WriteLine($"\nProfesor Oak: Excelente, elegiste a {pjugador.name}.");
            Console.WriteLine($"({pjugador.name} ha sido añadido a tu Pokédex)");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        private void ElegirRival()
        {
            int codigo;

            do
            {
                codigo = rnd.Next(1, 4);
                prival = arbol.Buscar(codigo);
                if (codigo == 1)
                {
                    atqr = "Placaje";
                    break;
                }
                else if (codigo == 2)
                {
                    atqr = "Placaje";
                    break;
                }
                else
                {
                    atqr = "Arañazo";
                    break;
                }

            } while (prival == null || prival.code == pjugador.code);

            Console.WriteLine("Gary: ¡Una batalla, o ¿tienes miedo?");
            Console.WriteLine("(Hora de pelear. Prepárate)");
            Console.WriteLine();

            Console.WriteLine($"Gary ha elegido a {prival.name} para pelear.");
            Console.WriteLine($"Los PS de {prival.name} son {prival.ps}. Nivel 5");
            Console.WriteLine($"Los PS de tu { pjugador.name} son {pjugador.ps}. Nivel 5");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        private void Batalla()
        {
            int opcion;

            do
            {
                Console.WriteLine("1) Luchar");
                Console.WriteLine("2) Mochila");
                Console.WriteLine("3) Pokémon");
                Console.WriteLine("4) Huida");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Atacar();
                        break;

                    case 2:
                        Console.WriteLine("\nNo tienes objetos disponibles.\n");
                        break;

                    case 3:
                        Console.WriteLine("\nNo tienes más Pokémon disponibles.\n");
                        break;

                    case 4:
                        Console.WriteLine($"\n({pjugador.name} ha huido)");
                        Console.WriteLine("Gary: Sabía que no tenías coraje JAJAJA.");
                        pjugador.ps = 0;
                        break;

                    default:
                        Console.WriteLine("\nSistema: Opción inválida.\n");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (pjugador.ps > 0 && prival.ps > 0);
        }

        private void Atacar()
        {
            int dañoJugador = rnd.Next(3, 7);
            prival.ps -= dañoJugador;

            Console.WriteLine($"{pjugador.name} uso "+atqp);
            Console.WriteLine($"{prival.name} perdió {dañoJugador} PS.");

            if (prival.ps <= 0)
            {
                Console.WriteLine($"\n¡{prival.name} se debilitó!");
                Console.WriteLine($"Gary: Tsk... ganaste esta vez, {player}.");
                Console.WriteLine("Sistema: ¡Has ganado la batalla!");
                return;
            }

            int dañoRival = rnd.Next(3, 7);
            pjugador.ps -= dañoRival;

            Console.WriteLine($"{prival.name} uso "+atqr);
            Console.WriteLine($"{pjugador.name} perdió {dañoRival} PS.");

            Console.WriteLine($"\nPS de {pjugador.name}: {Math.Max(pjugador.ps, 0)}");
            Console.WriteLine($"PS de {prival.name}: {Math.Max(prival.ps, 0)}\n");

            if (pjugador.ps <= 0)
            {
                Console.WriteLine($"\n¡{pjugador.name} se debilitó!");
                Console.WriteLine("Gary: JAJAJA, sabía que mi Pokémon era mejor.");
                Console.WriteLine("Sistema: Has perdido la batalla.");
            }
        }

        private void Final()
        {
            Console.WriteLine($"\nGracias por jugar, {player.ToUpper()} <3");
            Console.WriteLine("Presiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}
