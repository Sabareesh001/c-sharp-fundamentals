# Task 6: Events and Delegates

## Objective

Learn how to use C# events and delegates to implement a scoring system that responds to achievement milestones.

## Setup Instructions

1. Navigate to the `Task6` directory
2. Run `dotnet run` to start the application

## What It Does

- Implements a `Score` class that tracks points and raises an event when achievements are unlocked
- Uses a delegate (`AchievementUnlocked`) to define the event signature
- The `Announce` class subscribes to the score events and congratulates the player
- Demonstrates async/await with delayed score increases

## Dependencies

- .NET 10.0 or later

## Example Usage

```
Scored 20 more points
Scored 30 more points
Scored 30 more points
Yayy you scored 80
```

## Key Concepts

- **Delegates**: Function types that define method signatures
- **Events**: Built on top of delegates to provide a publish-subscribe pattern
- **Event Subscriber**: The `Announce` class subscribes to achievement events
- **Async/Await**: Non-blocking operations using `Task` and `Task.Delay()`

## How Events Decouple Producer and Consumer

This task demonstrates loose coupling through events:

### Without Events (Tight Coupling)

```csharp
// Score class would need to directly call Announce
public class Score {
    private Announce announce = new Announce();
    public void UpdateScore() {
        if (points > 50) {
            announce.Congratulate(points);  // Direct dependency
        }
    }
}
```

**Problem**: `Score` is tightly coupled to `Announce`. If you want to add logging or email notifications, you must modify `Score`.

### With Events (Loose Coupling)

```csharp
public class Score {
    public event AchievementUnlockedEvent? AchievementUnlockedEvent;

    public void UpdateScore() {
        if (points > 50) {
            AchievementUnlockedEvent?.Invoke(points);  // Raises event
        }
    }
}

public class Announce {
    public Announce(Score score) {
        score.AchievementUnlockedEvent += Congratulate;  // Subscribes
    }
}
```

**Benefit**: `Score` doesn't know or care about `Announce`. Any handler can subscribe to the event. You can add multiple handlers (email, logging, sound) without changing `Score`.

### Real-World Analogy

- **Producer (Score)**: A newspaper publisher publishes news
- **Consumer (Announce)**: Subscribers subscribe to read the news
- The publisher doesn't need to know who subscribes or what they do with the news—they just publish
