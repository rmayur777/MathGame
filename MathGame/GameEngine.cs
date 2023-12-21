using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber}  - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber}  * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}.Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber}  + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }

        internal void AdditionGameMedium(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(10, 39);
                secondNumber = random.Next(10, 39);

                Console.WriteLine($"{firstNumber}  + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }

        internal void SubtractionGameMedium(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(10, 39);
                secondNumber = random.Next(10, 39);

                Console.WriteLine($"{firstNumber}  - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGameMedium(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(10, 39);
                secondNumber = random.Next(10, 39);

                Console.WriteLine($"{firstNumber}  * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }


        internal void DivisionGameMedium(string message)
        {
            var score = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionNumbers = Helpers.GetDivisionNumbersMedium();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}.Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void AdditionGameHard(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(80, 500);
                secondNumber = random.Next(80, 500);

                Console.WriteLine($"{firstNumber}  + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }

        internal void SubtractionGameHard(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(80, 499);
                secondNumber = random.Next(80, 499);

                Console.WriteLine($"{firstNumber}  - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGameHard(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(80, 499);
                secondNumber = random.Next(80, 499);

                Console.WriteLine($"{firstNumber}  * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGameHard(string message)
        {
            var score = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionNumbers = Helpers.GetDivisionNumbersHard();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game over. Your final score is {score}.Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
