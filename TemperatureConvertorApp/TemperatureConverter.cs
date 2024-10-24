namespace TemperatureConvertorApp;

public abstract class TemperatureConverter
{
    protected double temperature;
    
    protected TemperatureConverter(double temperature)
    {
        this.temperature = temperature;
    }

    public abstract double Convert();

    public double Temperature
    {
        get { return temperature; }
        set { temperature = value; }
    }
}