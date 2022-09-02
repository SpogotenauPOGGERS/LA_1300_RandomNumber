using System;

namespace RN__LA1300;
    internal class Program
    {

    int guesses = 1;

    static void Main(string[] args)
        {
        Program game = new Program();
        game.startScreen();
        game.userInputCheck();
        while (game.correctAnswer())
        {
            game.startScreen();
            game.userInputCheck();
        }
        }
        public void startScreen()
        {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Herzlich willkommen beim Numberguessing Game");
        Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht und du sollst sie errate!");
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Drücken Sie ENTER um das Spiel zu starten");
        Console.ReadLine();
        }
    public void userInputCheck() 
    {
        Random randomnumber = new Random();
        int correctAnswer = randomnumber.Next(100) + 1;
        int userGuess = 1;
        guesses = 0;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            guesses++;
            Console.Write("Geratene Zahl: ");
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bitte gib nur Zahlen ein");
                guesses--;
                continue;
            }
            if (userGuess < correctAnswer && userGuess > 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Die gesuchte Zahl ist grösser als deine Zahl");
            }
            else if (userGuess > correctAnswer && userGuess < 100)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Die gesuchte Zahl ist kleiner als deine Zahl");
            }
            else if (userGuess == correctAnswer) { }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bitte gib nur Zahlen zwischen 1 und 100 ein!");
                guesses--;
            }
        } while (userGuess != correctAnswer);
        
    }

    public bool correctAnswer()
    {
        bool again = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Gratulation du hast die geheime Zahl in {guesses} versuchen erratet!");
        Console.Write("Möchtest du nochmals spielen? [j/n]");
        string repeat = Console.ReadLine();
            if (repeat == "j")
            {
                
               
            }
            else if (repeat == "n")
            {
                
                again = false;
                Console.WriteLine("Vielen Dank fürs spielen bis zum nächsten mal :)");
            }
         
        return again;
    }
    }
