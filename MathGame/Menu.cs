namespace MathGame
{
    internal class Menu

    {
        GameEngine gameEngine = new(); 
          internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game");
            Console.WriteLine("Press any key to show menu.");
            Console.ReadLine();
            Console.WriteLine("\n");
            bool isGameOn = true;

            do
            {
                Console.Clear();

                Console.WriteLine(@$"What game would you like to play today? Choose from below:
 V - View previous games 
 A - Addition
 S - Subtraction
 M - Multiplication
 D - Division
 Q - Quit the program");
                Console.WriteLine("--------------------------------------------------------------");
                
                string gameSelected = Console.ReadLine();

                string diffSelected = "";

                if(gameSelected == "s" || gameSelected == "m" || gameSelected == "a" || gameSelected == "d")
                {
                    Console.WriteLine(@$"Choose level of difficulty
  E - easy
  M - medium
  H - hard");
                    Console.WriteLine("--------------------------------------------------------------");

                    diffSelected = Console.ReadLine();

                    Console.WriteLine($"You selected {gameSelected} with {diffSelected} difficulty");
                    Console.ReadLine();
                }
                else if ( gameSelected == "v")
                {
                    Helpers.PrintGames();
                }else if( gameSelected == "q")
                {
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                }
                else 
                {
                    Console.WriteLine( "please choose an option");
                }

                
                

                if(diffSelected == "e")
                {
                   
                    switch (gameSelected.ToLower().Trim())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                            Console.ReadLine() ;
                        break;


                }

                }else if(diffSelected == "m")
                {
                    switch (gameSelected.ToLower().Trim())
                    {
                        case "a":
                            gameEngine.AdditionGameMedium("Addition game");
                            break;
                        case "s":
                            gameEngine.SubtractionGameMedium("Subtraction game");
                            break;
                        case "m":
                            gameEngine.MultiplicationGameMedium("Multiplication game");
                            break;
                        case "d":
                            gameEngine.DivisionGameMedium("Division game");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;


                    }

                }else if(diffSelected == "h")
                {
                    switch (gameSelected.ToLower().Trim())
                    {
                        case "a":
                            gameEngine.AdditionGameHard("Addition game");
                            break;
                        case "s":
                            gameEngine.SubtractionGameHard("Subtraction game");
                            break;
                        case "m":
                            gameEngine.MultiplicationGameHard("Multiplication game");
                            break;
                        case "d":
                            gameEngine.DivisionGameHard("Division game");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;


                    }

                }

            } while (isGameOn);


        }
    }
}
