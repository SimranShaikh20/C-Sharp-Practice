# Fruit Selection Application

A simple C# console application that demonstrates inheritance and basic user input handling. The program allows users to input the name of a fruit and displays the selected fruit.

## Features

- Demonstrates **inheritance** in C# by creating a base class (`FruitDetail`) and a derived class (`UserInput`).
- Accepts user input to dynamically set the fruit name.
- Prints the selected fruit using a method in the derived class.

## Program Structure

The program consists of the following components:

1. **FruitDetail Class**:
   - Represents the base class with a property `f_name` to hold the name of the fruit.

2. **UserInput Class**:
   - Inherits from `FruitDetail`.
   - Contains a method `PrintData()` to display the selected fruit.

3. **Main Program**:
   - Creates an instance of `UserInput`.
   - Accepts user input for the fruit name.
   - Calls the `PrintData()` method to print the result.

## How to Run

1. Clone or download the repository.
2. Open the project in any C# IDE, such as Visual Studio or Visual Studio Code.
3. Run the program.
4. Follow the prompts to enter the name of a fruit.


