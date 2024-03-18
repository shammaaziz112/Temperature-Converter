string TempConvert(float temperature, string unit){
        switch (unit)
        {
            case "C":
                float cel = temperature * 9 / 5 + 32;
                return $"{Math.Round((decimal)cel, 2)} F";
            case "F":
                float fr = (temperature - 32) * 5 / 9;
                return $"{Math.Round((decimal)fr, 2)} C";
            default:
                break;
        }
        return "Enter correct unit";
    }

Console.WriteLine("Enter a temperature:");
string? temperature = Console.ReadLine();

Console.WriteLine("Enter a unit (C or F):");
string? unit = Console.ReadLine();

Console.WriteLine(TempConvert(float.Parse(temperature), unit.ToUpper()));
