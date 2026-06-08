using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game5
{
    public class PokeDemo
    {
        private Arbol5 arbol = new Arbol5();
        private Random rnd = new Random();

        private string player;
        private string gender;
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
            EscenaSig();
            Final();
        }

        private void Intro()
        {
            Console.WriteLine("<----------- CARGANDO EL JUEGO *-* ----------->");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Hola, bienvenido/a al pueblo Paleta."); Thread.Sleep(1000);
            Console.WriteLine("Soy el profesor Oak."); Thread.Sleep(1000);
            Console.WriteLine();

            Console.Write("Primero, ¿eres chico o chica?");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                gender = "Chico"; //esto se entenderá mejor en la interfaz porque ahi se cambia la imagen xd
            }
            else
            {
                gender = "Chica";
            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Cuéntame un poco sobre ti, ¿cuál es tu nombre?: ");
            player = Console.ReadLine(); Console.Clear();

            Console.WriteLine($"Hola, {player}"); Thread.Sleep(1000);
            Console.WriteLine("Profesor Oak: Hoy elegirás un Pokémon que te acompañará en tus aventuras."); Thread.Sleep(1000);
            Console.WriteLine();
            Console.ReadKey(); Console.Clear();
        }

        public void CargarPokemon()
        {
            arbol.Insertar(new Pokemon("Bulbasaur", "Planta", 11, 10, 21));
            arbol.Insertar(new Pokemon("Charmander", "Fuego", 12, 9, 19));
            arbol.Insertar(new Pokemon("Squirtle", "Agua", 10, 11, 20));
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
                    if (pok == 1 || pok == 3)
                    {
                        atqp = "Placaje";
                    }
                    else if (pok == 2)
                    {
                        atqp = "Arañazo";
                    }

                    break;
                }

            } while (pjugador == null);

            Console.Clear();
            Console.WriteLine($"Profesor Oak: Excelente, elegiste a {pjugador.name}."); 
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine($"({pjugador.name} ha sido añadido a tu Pokédex)");
            Console.WriteLine();
            Thread.Sleep(3000); Console.Clear();
            Console.WriteLine("Profesor Oak: Ahora podrás ir de avent-");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Sistema: Pasos se oyen acercándose");
            Thread.Sleep(2000);Console.Clear();
            Console.WriteLine("!!!!!!!!!!!!!");
            Thread.Sleep(3000);
            Console.WriteLine("Sistema: Un misterioso chico llega .-.");
            Thread.Sleep(3000); Console.Clear();
        }

        private void ElegirRival()
        {
            int codigo;

            do
            {
                codigo = rnd.Next(1, 4);
                prival = arbol.Buscar(codigo);

            } while (prival == null || prival.code == pjugador.code);

            if (prival.code == 2)
            {
                atqr = "Arañazo";
            }
            else
            {
                atqr = "Placaje";
            }

            Console.WriteLine("Gary: ¡Una batalla o ¿tienes miedo?");
            Thread.Sleep(1500);  Console.WriteLine();
            Console.WriteLine("(Hora de pelear. Prepárate)");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine($"Gary ha elegido a {prival.name} para pelear.");
            Thread.Sleep(1500);
            Console.WriteLine($"Los PS de {prival.name} son {prival.ps}. Nivel 5"); Thread.Sleep(2000);
            Console.WriteLine($"Los PS de tu { pjugador.name} son {pjugador.ps}. Nivel 5"); Thread.Sleep(2000);
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
                        Console.WriteLine($"\n({pjugador.name} ha huido) 0-0"); Thread.Sleep(1500);

                        Console.WriteLine("Gary: Sabía que no tenías coraje JAJAJA.");
                        pjugador.ps = 0;
                        Thread.Sleep(1500); Console.Clear();
                        Console.WriteLine("Sistema: Gary sale del laboratorio con decepción."); Thread.Sleep(2000); Console.Clear();
                        Console.WriteLine("Profesor Oak: ..."); Thread.Sleep(3000);
                        Console.WriteLine("Profesor Oak: *se aclara la garganta* Disculpa a mi sobrino, está muy empeñado en luchar.");
                        Thread.Sleep(2000);
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
            int dañoJugador = rnd.Next(1, pjugador.atq + 1);
            int dfj = dañoJugador - (prival.def / 2); //sino no consideraba para nada la defensa qwq

            if (dfj < 1)
                dfj = 1;

            prival.ps -= dfj;

            Console.WriteLine($"{pjugador.name} uso " + atqp);
            Thread.Sleep(1000);
            Console.WriteLine($"{prival.name} perdió {dfj} PS.");
            Thread.Sleep(1000);
            Console.WriteLine();

            if (prival.ps <= 0)
            {
                Console.WriteLine($"\n¡{prival.name} se debilitó!");
                Thread.Sleep(1500); Console.Clear();
                Console.WriteLine($"Gary: Tsk... ganaste esta vez, {player}.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Sistema: ¡Has ganado la batalla!");
                Thread.Sleep(1500); Console.Clear();
                Console.WriteLine($"Gary: Tsk, no importa. La próxima vez te ganaré {player}. ¡Me voy a entrenar!");
                Thread.Sleep(1500);
                Console.WriteLine("Sistema: Gary sale del laboratorio."); Thread.Sleep(2000); Console.Clear();
                Console.WriteLine("Profesor Oak: Disculpa a mi sobrino, ese muchacho es demasiado orgulloso *suspira*");
                Thread.Sleep(1000);
                Console.WriteLine("Profesor Oak: ...");
                return;
            }

            int dañoRival = rnd.Next(1, prival.atq + 1);
            int dfr = dañoRival - (pjugador.def / 2);
            if (dfr < 1)
                dfr = 1;
            pjugador.ps -= dfr;

            Console.WriteLine($"{prival.name} uso "+atqr);
            Thread.Sleep(1000);
            Console.WriteLine($"{pjugador.name} perdió {dfr} PS.");
            Thread.Sleep(1000);
            Console.WriteLine($"\nPS de {pjugador.name}: {Math.Max(pjugador.ps, 0)}");
            Thread.Sleep(1000);
            Console.WriteLine($"PS de {prival.name}: {Math.Max(prival.ps, 0)}\n");

            if (pjugador.ps <= 0)
            {
                Console.WriteLine($"\n¡{pjugador.name} se debilitó!");
                Thread.Sleep(1000);
                Console.WriteLine("Gary: JAJAJA, sabía que mi Pokémon era mejor.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Sistema: Has perdido la batalla.");
                Thread.Sleep(1500); Console.Clear();
                Console.WriteLine("Gary: JAJAJA, ya no eres interesante. Iré a entrenar.");
                Thread.Sleep(1500);
                Console.WriteLine("Sistema: Gary sale del laboratorio."); Thread.Sleep(2000); Console.Clear();
                Console.WriteLine("Profesor Oak: Disculpa a mi sobrino, tenía muchas ganas de competir contigo.");
                Thread.Sleep(1500);
                Console.WriteLine("Profesor Oak: Ahora tu pokemon debe descansar hasta recuperarse");
                Thread.Sleep(1500);
                Console.WriteLine("Profesor Oak: ...");
                Console.ReadKey(); Console.Clear();
            }
        }
        private void EscenaSig()
        {
            Thread.Sleep(500);
            Console.WriteLine("Profesor Oak: De todos modos, toma esto...");
            Thread.Sleep(2500); Console.Clear();
            Console.WriteLine("Sistema: Recibiste [1 pokebola]");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("Profesor Oak: Esto te será muy útil en tu aventura de hoy en más"); Thread.Sleep(2000);
            Console.WriteLine("Profesor Oak: Con esto podrás capturar más pokemones y completar tu Pokedex"); Thread.Sleep(2000);
            Console.WriteLine("Profesor Oak: Increíble, ¿verdad?");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("Sistema: Pokebola se ha añadido a tu bolsa de objetos");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("Profesor Oak: Usa esto cuando el pokemon salvaje tenga menos vida, sino podría escapar"); Thread.Sleep(2500);
            Console.WriteLine($"Profesor Oak: ¡Bueno! No te quito más tiempo. Ve y diviertete en tu aventura, {player}");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("Sistema: Sales del laboratorio y vas hacia las afueras del Pueblo Paleta");
            Console.ReadKey(); Console.Clear();
        }
        private void Final()
        {
            Console.WriteLine("VERSIÓN DEMO ACABADA  TwT"); 
            Thread.Sleep(2000); Console.Clear();
            Console.WriteLine("Saliendo... OwO");
            Thread.Sleep(2000); Console.Clear();
            Console.WriteLine($"\nGracias por jugar, {player.ToUpper()} <3");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("----- Presiona ENTER para salir.----------");
            Console.ReadKey();
        }
    }
}
