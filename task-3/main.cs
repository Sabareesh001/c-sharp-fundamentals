List<string> list = [];

while (Actions()) ;

bool Actions()
{
    Console.WriteLine("================================================");
    Console.WriteLine("Pick an action : ");
    Console.WriteLine("1. add item");
    Console.WriteLine("2. remove item");
    Console.WriteLine("3. display items");
    Console.WriteLine("4. quit");
    Console.Write("Enter your Input : ");
    return getActionInput();
}

bool getActionInput()
{
    var action = Console.Read();
    Console.ReadLine();
    switch (action)
    {
        case '1':
            AddItem();
            break;
        case '2':
            RemoveItem();
            break;
        case '3':
            DisplayItems();
            break;
        case '4':
            return false;
        default:
            break;
    }
    return true;
}

void AddItem()
{
    Console.Write("Enter your item to be added : ");
    var item = Console.ReadLine();
    Console.WriteLine("the item is " + item);
    list.Add(item);
    Console.WriteLine($"item {item} added to the list successfully");
}

void RemoveItem()
{
    Console.Write("Enter index of the element to be removed : ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int index))
    {
        try
        {
            list.RemoveAt(index);
            Console.WriteLine("Item removed Successfully");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Index is out of Range TRY AGAIN!!!");
            RemoveItem();
        }
    }
    else
    {
        Console.WriteLine("Invalid Input please enter an index");
        RemoveItem();
    }
}

void DisplayItems()
{
    Console.WriteLine($"[{string.Join(", ", list)}]");
}