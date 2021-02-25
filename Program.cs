using System;

namespace RockPaperScissors
{
    class Program
    {
        /// <summary>
        /// Solicita al usuario una opcion para jugar
        /// </summary>
        /// <param name= "option">La opcion seleccionada por el jugador</param>
        /// <param name= "iaOption">La opcion aleatoria seleccioanda por la IA</param>
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

        static void CheckWinner(int option, int aiOption)
        {
            //1: pierda
            //2: papel
            //3: tijera
            switch(option)
            {
                case 1:
                Console.WriteLine("Player: Piedra");
                break;
                case 2:
                Console.WriteLine("Player: Papel");
                break;
                case 3:
                Console.WriteLine("Player: Tijera");
                break;

            }
            switch(aiOption){

                 case 1:
                Console.WriteLine("IA: Piedra");
                break;
                case 2:
                Console.WriteLine("IA: Papel");
                break;
                case 3:
                Console.WriteLine("IA: Tijera");
                break;
            }

            //pierda < papel < tijeras < pierda
            if(option == 1) //Jugador pierda
            {
                switch(aiOption)
                {
                    case 1: //Pierda
                    Console.WriteLine("Emapte");
                    break;
                    case 2: //Papel
                    Console.WriteLine("Gana IA");
                    break;
                    case 3: //Tijera
                    Console.WriteLine("Gana Jugador");
                    break;
                }
            }
            else if(option == 2) //Jugador Papel
            {
                switch(aiOption)
                {
                    case 1: //Pierda
                    Console.WriteLine("Gana Jugador");
                    break;
                    case 2: //Papel
                    Console.WriteLine("Empate");
                    break;
                    case 3: //Tijera 
                    Console.WriteLine("Gana IA");
                    break;
                }
            }
            else if(option == 3) //Tijera
            {
                switch(aiOption)
                {
                    case 1: //Pierda
                    Console.WriteLine("Gana IA");
                    break;
                    case 2: //Papel
                    Console.WriteLine("Gana Jugador");
                    break;
                    case 3: //Tijera 
                    Console.WriteLine("Empate");
                    break;
                }
            }

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

            CheckWinner(option, aiOption);

            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}
