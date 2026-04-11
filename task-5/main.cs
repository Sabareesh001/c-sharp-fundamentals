try
{
    var count = 0;
    using (var fileReader = File.OpenText("./test.csv"))
    {
        while (fileReader.ReadLine() != null)
        {
            count++;
        }
    }
    Console.WriteLine($"There are {count} rows in the file");
    var fileWriter = File.CreateText("./row_report.txt");
    {
        fileWriter.WriteLine($"There are {count} rows in the file");
    }
    fileWriter.Close();
}
catch (FileNotFoundException)
{
    Console.WriteLine("FileNotFound check your path");
}