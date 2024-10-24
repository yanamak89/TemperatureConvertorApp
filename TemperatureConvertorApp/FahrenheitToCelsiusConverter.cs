namespace TemperatureConvertorApp;

public class FahrenheitToCelsiusConverter : TemperatureConverter
{
    public FahrenheitToCelsiusConverter(double temperature)
        : base(temperature)
    { }

    public override double Convert()
    {
        return (temperature - 32) * 5 / 9;
    }

}