# Cybersecurity Awareness Chatbot

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4)](https://dotnet.microsoft.com)
[![Language](https://img.shields.io/badge/language-C%23-239120)](https://learn.microsoft.com/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A C# console-based Cybersecurity Awareness Chatbot that provides users with basic guidance about password safety, phishing, safe browsing, and general online security.

## 🚀 Features

* **Personalised Greeting**: Asks the user for their name and uses it throughout the conversation.
* **Voice Greeting**: Plays a `.wav` audio greeting when the application starts.
* **Cybersecurity ASCII Banner**: Displays a visual cybersecurity-themed title screen when the application launches.
* **Interactive Chatbot**: Allows users to ask questions about cybersecurity and online safety.
* **Password Safety**: Provides advice about creating and protecting strong passwords.
* **Phishing Awareness**: Explains phishing and how users can identify suspicious messages and links.
* **Safe Browsing**: Provides recommendations for safer internet browsing.
* **Online Safety**: Gives general advice about protecting personal information and online accounts.
* **Input Validation**: Handles empty or invalid user input without crashing.
* **Colour-Coded Console Interface**: Uses console colours to distinguish chatbot messages, prompts, and information.
* **Typing Effect**: Displays chatbot responses character by character to create a more interactive experience.
* **Modular Structure**: Separates the application's functionality into different classes to improve readability and maintainability.

## 🛠️ Prerequisites

Before building or running the project, ensure you have the following installed:

* **.NET SDK**: Version 8.0 or later.
* **Visual Studio 2022**, Visual Studio Code, or another C# compatible IDE.
* **Windows operating system** is recommended because the application uses `System.Media.SoundPlayer` for the WAV voice greeting.

You can verify your installed .NET version using:

```bash
dotnet --version
```

## 📦 Installation & Setup

### 1. Clone the repository

```bash
git clone https://github.com/your-username/cybersecurity-awareness-chatbot.git
```

Move into the project directory:

```bash
cd cybersecurity-awareness-chatbot
```

### 2. Restore dependencies

Run:

```bash
dotnet restore
```

### 3. Check the project structure

The project should contain the following main files:

```text
recording/
│
├── Program.cs
├── Chatbot.cs
├── ConsoleUI.cs
├── logo.cs
├── recording.csproj
│
└── Properties/
    └── voice/
        └── greeting.wav
```

The `greeting.wav` file is used as the chatbot's voice greeting.

### 4. Build the project

Run:

```bash
dotnet build
```

If the build completes successfully, the application is ready to run.

## 💻 Usage

Start the application using:

```bash
dotnet run
```

When the application starts, the following sequence takes place:

1. The voice greeting is played.
2. The cybersecurity ASCII banner is displayed.
3. The chatbot asks the user for their name.
4. A personalised greeting is displayed.
5. The chatbot explains the topics it can assist with.
6. The user can enter cybersecurity-related questions.
7. The chatbot provides an appropriate response.
8. The user can type `bye`, `exit`, or `quit` to end the conversation.

### Example Interaction

```text
==============================================================
             CYBER SECURITY AWARENESS CHATBOT
==============================================================

Welcome to the Cyber Security Awareness Chatbot!
Learn how to stay safe online.

You can ask me about:
- Password Safety
- Phishing
- Safe Browsing
- My Purpose
- How Are You
- Cybersecurity
- Online Safety

Bot: Hello! What is your name?
You: Katty

**************************************************
Bot: Welcome, Katty! It is great to meet you.
Bot: I am your Cybersecurity Awareness Bot,
     and I am here to help you learn how to stay safe online.
**************************************************

You: What is phishing?

Bot: Phishing is when someone tries to trick you into
giving them sensitive information, such as passwords or
banking details. Be careful with suspicious emails,
messages, attachments, and links.
```

## 💬 Example Questions

The chatbot supports a variety of cybersecurity-related questions, including:

```text
How are you?
What is your purpose?
What can I ask you?
Who are you?
Tell me about yourself

What is a strong password?
How do I protect my password?
Should I share my password?
What is a password manager?

What is phishing?
How do I avoid phishing?
What is a phishing email?
What should I do with a suspicious link?

How can I browse safely?
Is this website safe?

What is cybersecurity?
How do I stay safe online?
How do I protect my personal information?
What is two-factor authentication?
Why should I update my software?
```

## 🏗️ Project Structure

The application uses multiple classes instead of placing all functionality inside `Program.cs`.

### `Program.cs`

Responsible for starting the application, loading the voice greeting, displaying the logo, and starting the chatbot.

### `Chatbot.cs`

Contains the main chatbot functionality, including:

* User name collection
* Input validation
* User interaction
* Cybersecurity responses
* Exit commands

### `ConsoleUI.cs`

Contains reusable console interface methods, including:

* Section headers
* Bot messages
* User prompts
* Personalised greetings
* Typing effects
* Console colours

### `logo.cs`

Responsible for displaying the application's cybersecurity-themed ASCII banner and introductory information.

### `recording.csproj`

Contains the project's .NET configuration, target framework, and required package references.

## 🔊 Voice Greeting

The application uses:

```csharp
System.Media.SoundPlayer
```

to play the `greeting.wav` file when the application starts.

The audio file should be stored at:

```text
Properties/voice/greeting.wav
```

The application checks whether the file exists before attempting to play it. This prevents a missing audio file from causing the entire chatbot to crash.

## 🛡️ Input Validation

The chatbot performs basic validation before processing user input.

For example, empty input is detected:

```csharp
if (string.IsNullOrWhiteSpace(input))
{
    ConsoleUI.BotMessage(
        "Please enter a question so I can help you."
    );

    continue;
}
```

This allows the chatbot to continue running instead of attempting to process invalid input.

The user's name is also checked before it is accepted.

## 🎨 Console Interface

The chatbot uses different console colours to make the interface easier to understand.

* **Cyan** — headings and chatbot interface elements
* **Green** — chatbot responses
* **Yellow** — user prompts and welcome information

A typing effect is also included to make responses appear gradually.

## 🧪 Testing

The application can be tested by running:

```bash
dotnet run
```

Example tests include:

| Test                      | Expected Result                             |
| ------------------------- | ------------------------------------------- |
| Enter a valid name        | Personalised greeting is displayed          |
| Enter an empty name       | User is asked to enter a valid name         |
| Enter an empty question   | Chatbot requests a question                 |
| Ask "How are you?"        | Chatbot provides a response                 |
| Ask about passwords       | Password safety advice is provided          |
| Ask about phishing        | Phishing advice is provided                 |
| Ask about safe browsing   | Safe browsing advice is provided            |
| Enter an unknown question | Default response is displayed               |
| Enter `bye`               | Chatbot ends the conversation               |
| Enter `exit`              | Chatbot ends the conversation               |
| Start application         | Voice greeting and ASCII logo are displayed |

## 🏗️ Building the Project

To build the application in Debug configuration:

```bash
dotnet build
```

To create a Release build:

```bash
dotnet build --configuration Release
```

The project targets:

```text
.NET 8.0
```

## 🔄 GitHub / CI Preparation

The project is structured so that it can be built through a GitHub Actions workflow.

A basic CI workflow can execute:

```bash
dotnet restore
dotnet build --configuration Release
```

This allows the project to be automatically checked after changes are pushed to a GitHub repository.

## 🤝 Contributing

This project was developed as part of the Programming 2A module.

If changes are made to the project, contributors should:

1. Create a new branch.
2. Make the required changes.
3. Test the application.
4. Ensure the project builds successfully.
5. Commit the changes.
6. Push the branch.
7. Create a pull request.

Example:

```bash
git checkout -b feature/chatbot-improvements
```

## 📄 License

Distributed under the **MIT License**. See the `LICENSE` file for more information.

## ✉️ Contact

**Katty**

Cybersecurity Awareness Chatbot
Programming 2A — PROG6221/w

Project Repository:

```text
https://github.com/your-username/cybersecurity-awareness-chatbot
```
