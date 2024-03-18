static string TempConvert(int temperature, char unit){
        if (unit == 'C'){
            int fr = temperature * 9 / 5 + 32;
            return fr + " F";
        }
        else if (unit == 'F'){
            int cel = (temperature - 32) * 5 / 9;
            return cel+ " C";
        }
        return "Enter correct measurement unit";
    }

Console.WriteLine(TempConvert(32, 'F'));
Console.WriteLine(TempConvert(100, 'C'));
