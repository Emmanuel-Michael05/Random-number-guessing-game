# Number Guessing Game Console Application

## Description
This project is a simple number guessing game built in C#. The player is prompted to guess a random number between 1 and 100, and the program provides feedback indicating whether the guess is too high or too low. The game keeps track of the number of guesses the player makes, and after a correct guess, the player can choose to play again or exit the game.

## Features
- **Random Number Generation**: The program generates a random number between 1 and 100 for each game session.
- **Player Input**: The player can guess the number and is informed if their guess is too high or too low.
- **Guess Tracking**: The number of guesses taken is displayed after the correct number is guessed.
- **Play Again Option**: After winning, the player can choose to play another round or exit the game.
- **Personalized Greeting**: The game greets the player by name and thanks them for playing at the end of the session.

## How to Use
1. The player is asked to enter their name at the start.
2. The player is then prompted to guess a number between 1 and 100.
3. The game provides feedback (`too high` or `too low`) based on the player's guess.
4. Once the correct number is guessed, the game displays the number of guesses made.
5. The player is then asked if they would like to play again (Y/N).
6. If the player selects 'Y', a new game starts; if 'N', the game exits with a thank you message.

## How to Run
1. Clone or download this repository.
2. Open the project in Visual Studio Code or any C# IDE.
3. Run the application by pressing `F5` or using the terminal/console to execute:
   ```bash
   dotnet run
Follow the prompts to start guessing numbers.
## Example Output
Enter your name: John
Welcome John. Have fun playing!!

Guess a number between 1-100:  
50
Guess: 50
50 is high

Guess a number between 1-100:  
30
Guess: 30
30 is low

Guess a number between 1-100:  
40
Guess: 40
You Win!
Guesses: 3

Would you like to play again: (Y/N)
## Files
Program.cs: Contains the logic for random number generation, handling player input, providing feedback, and managing the game flow (replay option).
## Error Handling
Invalid Input: The player must enter a valid integer when guessing numbers, or the program will throw an exception.

## Author
Emmanuel Michael Ikechukwu

This `README.md` provides an overview of the Number Guessing Game, explains how to play it, and gives instruct
