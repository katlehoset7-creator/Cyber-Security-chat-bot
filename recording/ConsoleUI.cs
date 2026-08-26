using System;
using System.Threading;

namespace recording
{
    internal class ConsoleUI
    {
        // Displays a formatted section header.
        public static void Header(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==============================================");
            Console.WriteLine($"              {title}");
            Console.WriteLine("==============================================");

            Console.ResetColor();
        }

        // Displays a chatbot message in green.
        public static void BotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Bot: ");

            Console.ResetColor();

            // Use the typing effect to make the chatbot
            // appear more conversational.
            TypeText(message);
        }

        // Displays the user's input prompt in yellow.
        public static void UserMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("You: ");

            Console.ResetColor();
        }

        // Displays the personalised greeting after the user
        // has entered their name.
        public static void PersonalGreeting(string name)
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************************");
            Console.ResetColor();

            BotMessage($"Welcome, {name}! It is great to meet you.");

            BotMessage(
                "I am your Cybersecurity Awareness Bot, and I am here to help you learn how to stay safe online."
            );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************************");
            Console.ResetColor();

            Console.WriteLine();
        }

        // Creates a typing effect by displaying one character
        // at a time instead of showing the entire response instantly.
        public static void TypeText(string text)
        {
            foreach (char character in text)
            {
                Console.Write(character);

                // Short delay between characters creates the
                // appearance of natural typing.
                Thread.Sleep(20);
            }

            Console.WriteLine();
        }
    }
}