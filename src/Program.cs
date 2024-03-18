static string TempConvert(float temperature, string unit){
        float tempResult = 0;
        string tempUnitResult = "";

        if (unit == "C"){
            tempResult = temperature * 9 / 5 + 32;
            tempUnitResult = "F";
        }
        else if (unit == "F"){
            tempResult = (temperature - 32) * 5 / 9;
            tempUnitResult = "C";
        }
        return $"{Math.Round((decimal)tempResult, 2)} {tempUnitResult}";
    }

Console.WriteLine("Enter a temperature:");
string? temperature = Console.ReadLine();

Console.WriteLine("Enter a unit (C or F):");
string? unit = Console.ReadLine();

Console.WriteLine(TempConvert(float.Parse(temperature), unit.ToUpper()));
