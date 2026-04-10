var a = Console.ReadLine();
if (long.TryParse(a, out long i))
{
    long factorial = 1;
    for (long j = 2; j <= i; j++)
    {
        try
        {
            factorial = checked(factorial * j);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Result too large to calculate");
            return;
        }
    }
    Console.WriteLine($"The factorial of {i} is {factorial}");
}
else
{
    Console.WriteLine("Invalid Input");
}
