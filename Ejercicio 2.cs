using System;

class Program
{
    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    
    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    
    static void Main()
    {
        Console.WriteLine("1- Celsius a Fahrenheit");
        Console.WriteLine("2- Fahrenheit a Celsius");
        Console.Write("Opción: ");
        string op = Console.ReadLine();
        
        if (op == "1")
        {
            Console.Write("Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Fahrenheit: {CelsiusAFahrenheit(c)}");
        }
        else if (op == "2")
        {
            Console.Write("Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine($"Celsius: {FahrenheitACelsius(f)}");
        }
    }
}
