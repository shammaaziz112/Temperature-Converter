static void TempConvert(int temperature, char unit){
        if (unit == 'C'){
            int fr = temperature * 9 / 5 + 32;
            Console.WriteLine(fr + " F");
        }
        else if (unit == 'F'){
            int cel = (temperature - 32) * 5 / 9;
            Console.WriteLine(cel+ " C");
        }
    }

TempConvert(32, 'F');
TempConvert(100, 'C');