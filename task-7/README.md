# Task 7: Async/Await and Concurrent Operations

## Objective

Learn how to use `async`/`await` for asynchronous programming and understand the difference between sequential and concurrent task execution.

## Setup Instructions

1. Navigate to the `task-7` directory
2. Run `dotnet run` to start the application

## What It Does

- Simulates cooking tasks (heating pan, fetching water/oil/veggies) using async methods with `Task.Delay()`
- Demonstrates how `async`/`await` works with time-delayed operations
- Shows a common beginner mistake: using `async`/`await` but executing sequentially

## Dependencies

- .NET 10.0 or later

## Example Output

```
Heating Pan started...
Going to fetch water...
Going to fetch oil...
Going to fetch veggies...
Pan is heated
fetched oil...
fetched veggies...
fetched water...
[pan heated, got water, got oil, got veggies]
```

## Key Concepts

- **async/await**: Syntax for writing asynchronous code that looks synchronous
- **Task**: Represents an asynchronous operation
- **Sequential vs Concurrent**: This example runs tasks sequentially (~10 seconds), but they could run concurrently (~4 seconds)

## Important Note: Sequential vs Concurrent Execution

The current code awaits each task one at a time, making it effectively **synchronous**:

```csharp
var pan = await heatPan();      // Wait 2s
var water = await fetchWater(); // Wait 4s (after pan)
var oil = await fetchOil();     // Wait 2s (after water)
```
**Total time: ~10 seconds**

For better performance, start all tasks and await them together:

```csharp
var panTask = heatPan();
var waterTask = fetchWater();
var oilTask = fetchOil();
var veggiesTask = fetchVeggies();

var pan = await panTask;
var water = await waterTask;
var oil = await oilTask;
var veggies = await veggiesTask;
```
**Total time: ~4 seconds** (only as long as the longest task)
