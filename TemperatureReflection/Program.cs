using System;
using System.IO;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        string pathToDll = @"/Users/yanamakogon/RiderProjects/TemperatureConvertorApp/TemperatureConvertorApp/bin/Debug/net8.0/TemperatureConvertorApp.dll";

        if (File.Exists(pathToDll))
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(pathToDll);
                
                Console.WriteLine("Перевірка типів у збірці:");
                foreach (Type type in assembly.GetTypes())
                {
                    Console.WriteLine("Знайдено тип: " + type.FullName);
                }
                
                PerformConversion(assembly, "TemperatureConvertorApp.CelsiusToFahrenheitConverter", 
                    25.0, "\u00b0C", "\u00b0F");
                PerformConversion(assembly, "TemperatureConvertorApp.FahrenheitToCelsiusConverter", 
                    77.0, "\u00b0F", "\u00b0C");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка завантаження збірки: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Файл .dll не знайдено за вказаним шляхом: " + pathToDll);
        }
    }

    private static void PerformConversion(Assembly assembly, 
        string converterTypeName, double inputValue,
        string inputUnit, string outputUnit)
    {
        Type converterType = assembly.GetType(converterTypeName);
        if (converterType != null)
        {
            try
            {
                object converterInstance =
                    Activator.CreateInstance(converterType, new object[] { inputValue });

                MethodInfo convertMethod = converterType.GetMethod("Convert");
                if (convertMethod != null)
                {
                    object result = convertMethod.Invoke(converterInstance, null);
                    Console.WriteLine("{0}{1} = {2}{3}", inputValue, inputUnit, result.GetType, outputUnit);
                }
                else
                {
                    Console.WriteLine("Метод Convert не знайдено для типу: " + converterTypeName);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Помилка при конвертації для типу: " + converterTypeName + converterType
                + " - " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Клас " + converterTypeName + " не знайдено.");
        }
    }
}
