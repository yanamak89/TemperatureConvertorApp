namespace TemperatureConvertorApp;

public class CelsiusToFahrenheitConverter : TemperatureConverter
{
    private double temperature;

    public CelsiusToFahrenheitConverter(double temperature) : base(temperature)
    {
        this.temperature = temperature;
    }

    public override double Convert()
    {
        return (temperature * 9 / 5) + 32;
    }
}