async Task makeFood()
{
    // Start all tasks without awaiting immediately
    var panTask = heatPan();
    var waterTask = fetchWater();
    var oilTask = fetchOil();
    var veggiesTask = fetchVeggies();

    // Wait for all to complete
    var pan = await panTask;
    var water = await waterTask;
    var oil = await oilTask;
    var veggies = await veggiesTask;

    List<string> result = [pan, water, oil, veggies];
    Console.WriteLine($"[{string.Join(", ", result)}]");
}

await makeFood();

async Task<string> heatPan()
{
    Console.WriteLine("Heating Pan started...");
    await Task.Delay(2000);
    Console.WriteLine("Pan is heated");
    return "pan heated";
}
async Task<string> fetchWater()
{
    Console.WriteLine("Going to fetch water...");
    await Task.Delay(4000);
    Console.WriteLine("fetched water...");
    return "got water";
}
async Task<string> fetchOil()
{
    Console.WriteLine("Going to fetch oil...");
    await Task.Delay(2000);
    Console.WriteLine("fetched oil...");
    return "got oil";
}
async Task<string> fetchVeggies()
{
    Console.WriteLine("Going to fetch veggies...");
    await Task.Delay(2000);
    Console.WriteLine("fetched veggies...");
    return "got veggies";
}
