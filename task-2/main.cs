
public class MainClass
{
    private class Person(string Name, int age)
    {
        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name} and I am {age} years old");
        }
    }
    public static void Main()
    {
        var p1 = new Person("Ram", 25);
        var p2 = new Person("Alice", 20);

        p1.Introduce();
        p2.Introduce();
        
    }
}

