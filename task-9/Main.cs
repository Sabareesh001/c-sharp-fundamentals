using System.Reflection;

// Scan the entire assembly for types with [Runnable] methods
var assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes();

Console.WriteLine("=== Scanning Assembly for [Runnable] Methods ===\n");

foreach (var type in types)
{
    // Get all methods from the type
    var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

    foreach (var method in methods)
    {
        var attribute = Attribute.GetCustomAttribute(method, typeof(Runnable));
        if (attribute != null)
        {
            Console.WriteLine($"[{type.Name}] Found method with [Runnable] attribute: {method.Name}");

            try
            {
                // Dynamically instantiate the class and invoke the method
                var instance = Activator.CreateInstance(type);
                method.Invoke(instance, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error invoking method: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}

[AttributeUsage(AttributeTargets.Method)]
class Runnable : Attribute
{
}

class Greet
{
    [Runnable]
    public void SayHello()
    {
        Console.WriteLine("  Output: Hello !!!!");
    }

    public void SayNeverComeBack()
    {
        Console.WriteLine("  (This method has no [Runnable] attribute)");
    }
}

class Calculator
{
    [Runnable]
    public void DisplaySum()
    {
        int sum = 5 + 10;
        Console.WriteLine($"  Output: Sum of 5 + 10 = {sum}");
    }

    [Runnable]
    public void DisplayProduct()
    {
        int product = 5 * 10;
        Console.WriteLine($"  Output: Product of 5 * 10 = {product}");
    }
}

class Logger
{
    [Runnable]
    public void LogMessage()
    {
        Console.WriteLine("  Output: Logging system initialized successfully");
    }
}
