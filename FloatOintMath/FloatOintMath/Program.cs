// See https://aka.ms/new-console-template for more information
float tempC = 22.5f;      //declaring a float value
double sallary = 2700.20d;    //declaring a double value
decimal money = 500.45m;    //declaring a decimal value
float f = 1.25E5f;    //scientific number notation with float type
Console.WriteLine(tempC);
Console.WriteLine(sallary);
Console.WriteLine(money);
Console.WriteLine(f);

//tempF =(TempC x 9) /5+32

float tempF;
Console.WriteLine("Celcius: " + tempC);
tempF = (tempC * 9) / 5 + 32;
Console.WriteLine( "Fahrenheit: " + tempF);