using TemperatureConvertorApp;

public class Program()
{
    public static void Main(string[] args)
    {
        TemperatureConverter celsiusConverter = new CelsiusToFahrenheitConverter(25);
        Console.WriteLine("25\u00b0C = {0}\u00b0F", celsiusConverter.Convert());

        TemperatureConverter fahrenheitToCelsiusConverter = new FahrenheitToCelsiusConverter(77);
        Console.WriteLine("77\u00b0F = {0}\u00b0C", fahrenheitToCelsiusConverter.Convert());
        
    }
}