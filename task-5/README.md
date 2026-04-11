# Task 5: CSV File Row Counter

## Objective

Learn file I/O operations in C# by reading a CSV file, counting rows, and writing a summary report.

## Setup Instructions

1. Navigate to the `task-5` directory
2. Place a `test.csv` file in the `task-5` directory
3. Run `dotnet run` to execute the application

## What It Does

- Opens and reads a CSV file named `test.csv`
- Counts the total number of rows in the file
- Displays the row count in the console
- Creates and writes a summary report to `row_report.txt`
- Handles `FileNotFoundException` gracefully if the CSV file is not found

## Dependencies

- .NET 10.0 or later
- A `test.csv` file in the task-5 directory

## Example Output

```
There are 5 rows in the file
```

The output is also written to `row_report.txt`:

```
There are 5 rows in the file
```

## Key Concepts

- File I/O with `File.OpenText()` and `File.CreateText()`
- Using statements for resource management
- Exception handling with try-catch blocks
- Reading file contents line by line
- Writing data to files
