# Task 9: Reflection and Custom Attributes

## Objective

Build an application that discovers and executes methods based on custom attributes using reflection.

## Requirements

- Define a custom attribute (`[Runnable]`)
- Create multiple classes with methods decorated with `[Runnable]`
- Use reflection to scan the assembly for methods marked with `[Runnable]`
- Invoke discovered methods dynamically and display their outputs

## Features

- **Custom Attribute**: `[Runnable]` attribute marks methods for execution
- **Assembly Scanning**: Uses `Assembly.GetExecutingAssembly()` to find all types in the assembly
- **Dynamic Invocation**: Uses reflection to instantiate classes and invoke methods at runtime
- **Multiple Classes**: Includes `Greet`, `Calculator`, and `Logger` classes

## Classes

1. **Greet** - Contains greeting methods
   - `SayHello()` [Runnable]
   - `SayNeverComeBack()` (no attribute)

2. **Calculator** - Performs calculations
   - `DisplaySum()` [Runnable]
   - `DisplayProduct()` [Runnable]

3. **Logger** - Simulates logging
   - `LogMessage()` [Runnable]

## How to Run

```bash
dotnet run
```

## Key Concepts

- Custom attributes using `[AttributeUsage]`
- Reflection: `Assembly.GetExecutingAssembly()`, `GetTypes()`, `GetMethods()`
- Dynamic instantiation with `Activator.CreateInstance()`
- Dynamic method invocation with `method.Invoke()`
- `BindingFlags` for filtering method searches
