﻿// ** TempConvert Function **
string TempConvert(float temperature, char unit)
{
    Console.ForegroundColor = ConsoleColor.Green;
    switch (unit)
    {
        case 'C':
            float cel = temperature * 9 / 5 + 32;
            return $"Converted: {temperature} {unit} = {Math.Round((decimal)cel, 2)} F";
        case 'F':
            float fr = (temperature - 32) * 5 / 9;
            return $"Converted: {temperature} {unit} = {Math.Round((decimal)fr, 2)} C";
        default:
            throw new UnsupportedValue("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
    }
}

// ** PrintDivider **
void PrintDivider()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
}

// ** Main **
Console.ForegroundColor = ConsoleColor.Blue;
string title = @" ____  ____  _  _  ____  ____  ____   __  ____  _  _  ____  ____     ___  __   __ _  _  _  ____  ____  ____  ____  ____ 
(_  _)(  __)( \/ )(  _ \(  __)(  _ \ / _\(_  _)/ )( \(  _ \(  __)   / __)/  \ (  ( \/ )( \(  __)(  _ \(_  _)(  __)(  _ \
  )(   ) _) / \/ \ ) __/ ) _)  )   //    \ )(  ) \/ ( )   / ) _)   ( (__(  O )/    /\ \/ / ) _)  )   /  )(   ) _)  )   /
 (__) (____)\_)(_/(__)  (____)(__\_)\_/\_/(__) \____/(__\_)(____)   \___)\__/ \_)__) \__/ (____)(__\_) (__) (____)(__\_)";

Console.WriteLine(title);
Console.WriteLine();

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
        char unit = char.Parse(inputArr[1].ToUpper());

        //? Way 1 using function
        Console.WriteLine(TempConvert(temperature, unit));

        //? Way 2 using class
        // TemperatureConverter.Convert(temperature, char.Parse(unit));

        PrintDivider();

    }
    catch (UnsupportedValue ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
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
    catch (System.Exception)
    {
        throw;
    }
}

// ** TemperatureConverter Class **
class TemperatureConverter
{
    public static void Convert(float temp, char unit)
    {
        float? convertResult;

        if (unit == 'F')
        {
            convertResult = (temp - 32) * 5 / 9;
            Console.WriteLine($"Converted: {temp} {unit} = {Math.Round((decimal)convertResult, 2)} C");
        }
        else if (unit == 'C')
        {
            convertResult = temp * 9 / 5 + 32;
            Console.WriteLine($"Converted: {temp} {unit} = {Math.Round((decimal)convertResult, 2)} F");
        }
    }
}

class UnsupportedValue : Exception
{
    public UnsupportedValue(string massage) : base(massage)
    { }
}