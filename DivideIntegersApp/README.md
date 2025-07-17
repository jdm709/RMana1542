# Divide Integers Application

This is a simple C# console application that performs division of two integers obtained from user input. The application demonstrates error handling using try-catch blocks to manage potential exceptions that may arise during the conversion and division processes.

## Features

- Prompts the user to enter two integers as strings.
- Converts the string inputs to integers.
- Performs division and handles exceptions:
  - `FormatException`: Caught when the input strings cannot be converted to integers.
  - `DivideByZeroException`: Caught when attempting to divide by zero.
- Prints appropriate error messages for each exception or the result of the division.

## How to Run the Application

1. Ensure you have the .NET SDK installed on your machine.
2. Clone or download the repository.
3. Navigate to the project directory in your terminal.
4. Build the application using the command:
   ```
   dotnet build
   ```
5. Run the application using the command:
   ```
   dotnet run
   ```

Follow the prompts to enter two integers, and the application will display the result of the division or any error messages if exceptions occur.