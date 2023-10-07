using System;
using Serilog;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("C:\\ViVi\\CodeLearn\\SerilogPlayCode\\ConsoleApp\\Logs\\myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Hello, world!");
            int a = 10, b = 0;
            try
            {
                Log.Debug("Diving {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
