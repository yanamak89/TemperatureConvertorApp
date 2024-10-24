using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введить шлях до .dll: ");
        string pathToDll = Console.ReadLine();

        if (File.Exists(pathToDll))
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(pathToDll);
                Console.WriteLine("\nІнформація про складання: ");
                Console.WriteLine("\nНазва складання: " + assembly.FullName);

                Console.WriteLine("\nТипи, що входять до складу збірки: ");
                foreach (Type type in assembly.GetTypes())
                {
                    Console.WriteLine("\nТип: " + type.FullName);
                    Console.WriteLine("Базовий тип: " + type.BaseType);
                    
                    Console.WriteLine("Властивості: ");
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        Console.WriteLine("- " + property.Name + " : " + 
                                          property.PropertyType);
                    }

                    Console.WriteLine("Методи:");
                    foreach (MethodInfo method in type.GetMethods())
                    {
                        Console.WriteLine("- " + method.Name);
                    }

                    Console.WriteLine("Поля:");
                    foreach (FieldInfo field in type.GetFields())
                    {
                        Console.WriteLine("- " + field.Name + " : " + field.FieldType);
                    }

                    Console.WriteLine("Конструктори:");
                    foreach (ConstructorInfo constructor in type.GetConstructors())
                    {
                        Console.WriteLine("- " + constructor.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка завантаження складання: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Файл .dll не знайдено за вказаним шляхом: " + pathToDll);
        }
    }
}