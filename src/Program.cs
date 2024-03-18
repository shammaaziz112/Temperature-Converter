string TempConvert(float temperature, string unit)
{
    switch (unit)
    {
        case "c":
            float cel = temperature * 9 / 5 + 32;
            return $"{Math.Round((decimal)cel, 2)} F";
        case "f":
            float fr = (temperature - 32) * 5 / 9;
            return $"{Math.Round((decimal)fr, 2)} C";
        default:
            break;
    }
    return "";
}


while (true)
{

    try
    {
        Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");

        string? input = Console.ReadLine();

        if (input == "" || input is null || input.ToLower() == "quit")
        {
            Console.WriteLine("Program terminated");
            return;
        }

        string[] inputArr = input.Split(" ");

        float temperature = Convert.ToInt64(inputArr[0]);
        string unit = inputArr[1].ToLower();

        if (unit == "f" || unit == "c")
        {
            Console.WriteLine(TempConvert(temperature, unit));
        }
        else
        {
            throw new ArgumentException();
        }

        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

    }
    catch (System.FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a numeric temperature.");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine("Invalid. Please enter a temperature and unit.");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }
    catch (System.Exception)
    {
        throw;
    }
}


