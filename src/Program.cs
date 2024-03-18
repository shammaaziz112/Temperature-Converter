string TempConvert(float temperature, string unit)
{
    Console.ForegroundColor = ConsoleColor.Green;
    switch (unit)
    {
        case "C":
            float cel = temperature * 9 / 5 + 32;
            return $"Converted: {temperature} {unit} = {Math.Round((decimal)cel, 2)} F";
        case "F":
            float fr = (temperature - 32) * 5 / 9;
            return $"Converted: {temperature} {unit} = {Math.Round((decimal)fr, 2)} C";
        default:
            break;
    }
    return "";
}

void PrintDivider()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
}

while (true)
{
    try
    {
        Console.ResetColor();
        Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
        string? input = Console.ReadLine();

        if (input is null || input.ToLower() == "quit")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program terminated");
            return;
        }

        string[] inputArr = input.Split(" ");

        float temperature = float.Parse(inputArr[0]);
        string unit = inputArr[1].ToUpper();

        if (unit == "F" || unit == "C")
        {
            Console.WriteLine(TempConvert(temperature, unit));
        }
        else
        {
            throw new ArgumentException();
        }
        PrintDivider();

    }

    catch (System.IndexOutOfRangeException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid. Please enter a unit. Ex: 100 F or 30 C");
        PrintDivider();
    }
    catch (System.FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a numeric temperature.");
        PrintDivider();
    }
    catch (ArgumentException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
        PrintDivider();
    }
    catch (System.Exception)
    {
        throw;
    }
}
