﻿using System;
using static System.Console;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;
            Random random = new Random();

            while (isplay)
            {
                int numberOfAttempts = 0;
                WriteLine("Hello user!\nEnter the max number ");

                if (int.TryParse(ReadLine(), out int maxValue))
                {
                    int hiddenNumber = random.Next(0, maxValue + 1);
                    WriteLine("Excellently, we are can start\n\n\t<<If you get bored press space and Enter to exit>>\n");
                    do
                    {

                        WriteLine("\nTry to guess my number\n\n\tEnter the your number\n");
                        string enterValue = ReadLine().ToUpper();

                        if (enterValue == " ")
                        {
                            WriteLine($"Hmm, all right \nCome back whenever you want");
                            break;
                        }

                        if (int.TryParse(enterValue, out int number))
                        {
                            numberOfAttempts++;
                            if (number > hiddenNumber)
                            {
                                WriteLine("Very much, my number less");
                            }
                            else if (number < hiddenNumber)
                            {
                                WriteLine("Very Little, my number more ");
                            }
                            else
                            {
                                WriteLine("Сongratulations\nYou win");
                                break;
                            }
                        }
                    } while (true);
                    ReadLine();
                    WriteLine($"My number {hiddenNumber} \nYou try # {numberOfAttempts}  ");
                }
                else
                {
                    WriteLine($"Error no invalid number");
                    ReadLine();
                }


                WriteLine("Exit to Program ?\nY or N");

                string userSelection = ReadLine().ToUpper();

                switch (userSelection)
                {
                    case "Y":
                        isplay = false;
                        break;
                    case "N":
                        break;
                    default:
                        WriteLine("Error\nPress Enter to Continue");
                        ReadLine();
                        break;
                }
                Clear();
            }
        }
    }
}
