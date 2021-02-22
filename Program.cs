using System;

namespace RockPaperScissors
{
    class Program
    {
        /// <summary>
        /// Solicita al usuario una opcion para jugar
        /// </summary>
        /// <returns>La opcion seleccionada: 1 - piedra, 2 - papel, 3 - tijeras</returns>
        static int SelectOption()
        {
            Console.WriteLine("Seleciona la opcion a jugar:");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijeras");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        static int SelectRandomOption()
        {
            Random rnd = new Random();
            //1, 2 or 3
            int option = rnd.Next(1, 4);
            return option;
        }
        static void Main(string[] args)
        {
            //Selecionar una opcion a jugar (piedra, papel o tijera)
            //1: pierda
            //2: papel
            //3: tijeras
            int option = SelectOption();
            Console.WriteLine("Opcion seleccionada: " + option);

            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            int aiOption = SelectRandomOption();
            Console.WriteLine("Opcion seleccionada aleatoriamente: " + aiOption);

            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador



            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}
