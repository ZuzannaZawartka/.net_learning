using Microsoft.Extensions.DependencyInjection;
using MyLibrary;
using MyServices;
using Newtonsoft.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
//             Calculator calc = new Calculator();
//             int sum = calc.Add(5, 3);
//             var result = new { Operation = "Add", A = 5, B = 3, Result = sum };
//             string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
//             Console.WriteLine(jsonResult);
   
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggerService, ConsoleLogger>()
                .BuildServiceProvider();

           
            var logger = serviceProvider.GetService<ILoggerService>();
            logger.Log("Aplikacja uruchomiona.");


            int sum = new Calculator().Add(10, 15);
            logger.Log($"Wynik dodawania: {sum}");
        }
    }
}
