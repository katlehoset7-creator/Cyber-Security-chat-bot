using System;

namespace recording
{
    internal class logo
    {
        // Displays the title screen and cybersecurity ASCII artwork.
        public void Display()
        {
            // Clear the console so the logo starts on a clean screen.
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==============================================================");
            Console.WriteLine("             CYBER SECURITY AWARENESS CHATBOT");
            Console.WriteLine("==============================================================");

            Console.WriteLine();

            // ASCII art used as the chatbot's visual logo.
            Console.WriteLine(
            @"  ______ _       ___  _____  _   __  _   _  ___  _   _ _    _____ 
| ___ \ |     / _ \/  __ \| | / / | | | |/ _ \| | | | |  |_   _|
| |_/ / |    / /_\ \ /  \/| |/ /  | | | / /_\ \ | | | |    | |  
| ___ \ |    |  _  | |    |    \  | | | |  _  | | | | |    | |  
| |_/ / |____| | | | \__/\| |\  \ \ \_/ / | | | |_| | |____| |  
\____/\_____/\_| |_/\____/\_| \_/  \___/\_| |_/\___/\_____/\_/  
                                                                
                                                                  ");

            Console.ResetColor();

            Console.WriteLine();

            // Display a welcoming message to the user.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Cyber Security Awareness Chatbot!");
            Console.ResetColor();

            Console.WriteLine("Learn how to stay safe online.");
            Console.WriteLine();

            // Display the main topics that the chatbot understands.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can ask me about:");
            Console.ResetColor();

            Console.WriteLine("- Password Safety");
            Console.WriteLine("- Phishing");
            Console.WriteLine("- Safe Browsing");
            Console.WriteLine("- My Purpose");
            Console.WriteLine("- How Are You");
            Console.WriteLine("- Cybersecurity");
            Console.WriteLine("- Online Safety");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You will be asked for your name before we begin.");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine();
        }
    }
}
