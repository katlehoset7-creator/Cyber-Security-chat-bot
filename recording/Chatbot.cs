using System;

namespace recording
{
    internal class Chatbot
    {
        // Stores the user's name so that the chatbot can
        // personalise the conversation.
        private string userName = "";

        // Starts the chatbot conversation.
        public void Start()
        {
            ConsoleUI.Header("WELCOME");

            // Ask the user for their name before starting
            // the main chatbot conversation.
            GetUserName();

            // Display a personalised greeting.
            ConsoleUI.PersonalGreeting(userName);

            // Explain what the chatbot can help with.
            ConsoleUI.BotMessage(
                "You can ask me questions about passwords, phishing, safe browsing, cybersecurity, and online safety."
            );

            Console.WriteLine();

            // Continue the conversation until the user chooses
            // to exit the chatbot.
            while (true)
            {
                ConsoleUI.UserMessage();

                string? input = Console.ReadLine();

                // Validate the user's input before processing it.
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.BotMessage(
                        "Please enter a question so I can help you."
                    );

                    continue;
                }

                // Get an appropriate response from the chatbot.
                string response = GetResponse(input);

                // Check whether the user wants to leave.
                if (response == "EXIT")
                {
                    ConsoleUI.BotMessage(
                        $"Goodbye, {userName}! Stay safe online."
                    );

                    break;
                }

                // Display the chatbot's response.
                ConsoleUI.BotMessage(response);

                Console.WriteLine();
            }
        }

        // Requests the user's name and performs basic validation.
        private void GetUserName()
        {
            while (true)
            {
                ConsoleUI.UserMessage();
                Console.Write("Please enter your name: ");

                string? name = Console.ReadLine();

                // Check whether the user entered an empty name.
                if (string.IsNullOrWhiteSpace(name))
                {
                    ConsoleUI.BotMessage(
                        "I didn't receive a name. Please enter your name."
                    );

                    continue;
                }

                // Check that the name contains letters rather than
                // only numbers or symbols.
                bool containsLetter = false;

                foreach (char character in name)
                {
                    if (char.IsLetter(character))
                    {
                        containsLetter = true;
                        break;
                    }
                }

                if (!containsLetter)
                {
                    ConsoleUI.BotMessage(
                        "Please enter a valid name containing letters."
                    );

                    continue;
                }

                // Store the name once it has passed validation.
                userName = name.Trim();

                break;
            }
        }

        // Processes the user's question and returns an
        // appropriate cybersecurity-related response.
        private string GetResponse(string input)
        {
            // Convert the input to lowercase and remove unnecessary
            // spaces so that different ways of typing a question
            // can still be recognised.
            input = input.ToLower().Trim();

            // ----------------------------------------------------
            // GENERAL CONVERSATION
            // ----------------------------------------------------

            if (input.Contains("hello") ||
                input.Contains("hi") ||
                input.Contains("hey"))
            {
                return $"Hello {userName}! How can I help you with cybersecurity today?";
            }

            if (input.Contains("how are you"))
            {
                return "I'm doing well! I'm ready to help you stay safe online.";
            }

            if (input.Contains("thank") ||
                input.Contains("thanks"))
            {
                return "You're welcome! I'm always happy to help you stay safer online.";
            }

            // ----------------------------------------------------
            // CHATBOT PURPOSE
            // ----------------------------------------------------

            if (input.Contains("purpose") ||
                input.Contains("why were you created") ||
                input.Contains("what do you do"))
            {
                return "My purpose is to provide basic cybersecurity information and help you understand how to protect yourself online.";
            }

            if (input.Contains("what can i ask") ||
                input.Contains("what can i ask you") ||
                input.Contains("what can you help me with") ||
                input.Contains("what topics"))
            {
                return "You can ask me about password safety, phishing, safe browsing, cybersecurity, online safety, suspicious links, and protecting your personal information.";
            }

            if (input.Contains("who are you") ||
                input.Contains("tell me about yourself"))
            {
                return "I am a Cybersecurity Awareness Bot designed to provide basic advice about staying safe while using computers, websites, email, and online services.";
            }

            // ----------------------------------------------------
            // PASSWORD SAFETY
            // ----------------------------------------------------

            if (input.Contains("password"))
            {
                return "Use strong and unique passwords for your accounts. Avoid using your name, birthday, or other personal information. Do not share your passwords with other people, and consider using a password manager to help manage different passwords.";
            }

            if (input.Contains("strong password") ||
                input.Contains("secure password"))
            {
                return "A strong password should be difficult to guess. Use a combination of letters, numbers, and symbols, make it reasonably long, and avoid common words or personal information.";
            }

            if (input.Contains("password manager"))
            {
                return "A password manager can securely store your passwords so you do not have to remember every password yourself. It can also help you create strong and unique passwords.";
            }

            if (input.Contains("share my password") ||
                input.Contains("sharing password"))
            {
                return "You should avoid sharing your passwords. Your password is a private security credential and sharing it could allow another person to access your account.";
            }

            // ----------------------------------------------------
            // PHISHING
            // ----------------------------------------------------

            if (input.Contains("phishing"))
            {
                return "Phishing is when someone tries to trick you into giving them sensitive information, such as passwords or banking details. Be careful with suspicious emails, messages, attachments, and links.";
            }

            if (input.Contains("phishing email") ||
                input.Contains("suspicious email"))
            {
                return "A suspicious email may contain unexpected attachments, urgent requests, strange links, spelling mistakes, or requests for personal information. Verify the sender before clicking anything.";
            }

            if (input.Contains("suspicious link") ||
                input.Contains("fake link"))
            {
                return "Do not immediately click suspicious links. Check the website address carefully and consider visiting the official website directly instead of following an unexpected link.";
            }

            if (input.Contains("how do i avoid phishing") ||
                input.Contains("prevent phishing"))
            {
                return "To reduce the risk of phishing, be cautious with unexpected messages, check the sender's address, avoid suspicious links, and never provide sensitive information unless you are sure who you are dealing with.";
            }

            // ----------------------------------------------------
            // SAFE BROWSING
            // ----------------------------------------------------

            if (input.Contains("safe browsing") ||
                input.Contains("browsing"))
            {
                return "For safe browsing, use trusted websites, check website addresses carefully, avoid suspicious links, keep your browser updated, and avoid entering sensitive information on websites you do not trust.";
            }

            if (input.Contains("website") ||
                input.Contains("safe website"))
            {
                return "Before using a website, check that the address is correct and that you trust the website. Be especially careful when a website asks for passwords, banking information, or other sensitive details.";
            }

            // ----------------------------------------------------
            // GENERAL CYBERSECURITY
            // ----------------------------------------------------

            if (input.Contains("cybersecurity") ||
                input.Contains("cyber security"))
            {
                return "Cybersecurity is the practice of protecting computers, devices, networks, accounts, and information from unauthorised access, attacks, and other online threats.";
            }

            if (input.Contains("online safety") ||
                input.Contains("stay safe online"))
            {
                return "To stay safe online, use strong passwords, enable additional security features where available, avoid suspicious links, keep your software updated, and be careful about the personal information you share.";
            }

            if (input.Contains("personal information") ||
                input.Contains("private information"))
            {
                return "Be careful about sharing personal information online. Avoid publicly sharing sensitive details such as passwords, banking information, identification numbers, or information that could be used to guess your security questions.";
            }

            if (input.Contains("two factor") ||
                input.Contains("2fa") ||
                input.Contains("multi factor"))
            {
                return "Two-factor authentication adds another layer of security to your account. Instead of relying only on a password, it requires an additional verification method.";
            }

            if (input.Contains("update") ||
                input.Contains("software update"))
            {
                return "Keeping your operating system, browser, and applications updated is important because updates can include security fixes that help protect your device.";
            }

            // ----------------------------------------------------
            // EXIT COMMANDS
            // ----------------------------------------------------

            if (input == "bye" ||
                input == "exit" ||
                input == "quit" ||
                input.Contains("goodbye"))
            {
                return "EXIT";
            }

            // ----------------------------------------------------
            // DEFAULT RESPONSE
            // ----------------------------------------------------

            // If the chatbot cannot recognise the question,
            // provide a helpful response instead of crashing.
            return "I didn't quite understand that. Could you rephrase your question? You can ask me about passwords, phishing, safe browsing, cybersecurity, or online safety.";
        }
    }
}