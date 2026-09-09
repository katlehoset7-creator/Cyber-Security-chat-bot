using System;
using System.IO;
using System.Media;

namespace recording
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the location where the application is currently running.
// This makes the audio file path work on different computers.
string audioPath = "C:\\Users\\Student\\source\\repos\\recording\\recording\\Properties\\voice\\greeting_1.wav";
            );

            // Check whether the greeting audio file exists before
            // attempting to play it.
            if (File.Exists(audioPath))
            {
                try
                {
                    // SoundPlayer is used to play the chatbot's
                    // voice greeting when the application starts.
                    SoundPlayer player = new SoundPlayer(audioPath);

                    // PlaySync waits until the greeting has finished.
                    // This keeps the startup sequence simple and reliable.
                    player.PlaySync();
                }
                catch (Exception)
                {
                    // If the audio cannot be played, the chatbot
                    // can still continue running normally.
                    Console.WriteLine("Voice greeting could not be played.");
                }
            }
            else
            {
                // Inform the user if the audio file cannot be found.
                Console.WriteLine("Voice greeting file was not found.");
            }

            // Display the cybersecurity chatbot logo and
            // introduction screen.
            logo myLogo = new logo();
            myLogo.Display();

            // Create the chatbot object and start the conversation.
            Chatbot chatbot = new Chatbot();
            chatbot.Start();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
