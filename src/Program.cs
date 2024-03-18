string TempConvert(float temperature, char unit)
{
    switch (unit)
    {
        case 'c':
            float cel = temperature * 9 / 5 + 32;
            return $"{Math.Round((decimal)cel, 2)} F";
        case 'f':
            float fr = (temperature - 32) * 5 / 9;
            return $"{Math.Round((decimal)fr, 2)} C";
        default:
            break;
    }
    return "Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.";
}

Boolean isContinue = true;

while (isContinue)
{

    try
    {
        Console.WriteLine("Enter a temperature:");
        float temperature = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter a unit (C or F):");
        char unit = Char.ToLower(Convert.ToChar(Console.ReadLine()));
        if (unit == 'f' || unit == 'c')
        {
            Console.WriteLine(TempConvert(temperature, unit));
        }
        else
        {

            throw new ArgumentException();
        }

        Console.WriteLine("Do you went to Continue (y/n):");
        // string input = ;
        if (Console.ReadLine().ToLower() == "n")
        {
            isContinue = false;
        }



    }
    catch (System.FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a numeric temperature.");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
    }
    catch (System.Exception)
    {
        throw;
    }
}

Console.WriteLine("Program terminated");
