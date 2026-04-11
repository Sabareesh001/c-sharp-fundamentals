# Task 1: Factorial Calculator

## Objective

Build a program that computes the factorial of a user-provided number with overflow protection.

## Setup Instructions

1. Navigate to the `task-1` directory
2. Run `dotnet run` to start the application

## What It Does

- Prompts the user to enter a number
- Calculates the factorial of the input number
- Handles overflow exceptions gracefully when the result exceeds `long` capacity
- Validates user input and shows an error message for invalid entries

## Dependencies

- .NET 10.0 or later

## Example Usage

```
Enter number: 5
The factorial of 5 is 120
```

## Key Concepts

- Input validation with `long.TryParse()`
- Checked arithmetic for overflow detection
- For loops and factorial calculation
