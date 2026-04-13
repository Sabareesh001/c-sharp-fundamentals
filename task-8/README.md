# Task 8: Generics and Interfaces with Repository Pattern

## Objective

Implement a generic in-memory repository to perform CRUD (Create, Read, Update, Delete) operations using interfaces and generics.

## Requirements

- ✅ Generic `IRepository<T>` interface with CRUD methods
- ✅ Type constraints (`where T : class`)
- ✅ Generic repository implementation
- ✅ Sample entity (`Student`)
- ✅ Console UI demonstration

## Key Concepts

- **Generics**: `IRepository<T>` allows type-safe repository operations
- **Interfaces**: `IRepository<T>` defines the contract for repository behavior
- **Type Constraints**: `where T : class` restricts usage to reference types
- **CRUD Operations**: Add, Get, Update, Delete methods

## Running the Application

```bash
dotnet run
```

## Expected Output

```
[Name: Ramesh and Age: 21]
[]
```

The program demonstrates adding a student, printing the list, deleting the student, and printing the empty list.
