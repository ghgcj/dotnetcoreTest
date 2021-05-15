using System;
using System.Threading.Tasks;

namespace CoreConsole3._1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            // Console.WriteLine("\nWhat is your name? "); 
            // var name = Console.ReadLine(); 
            // var date = DateTime.Now; 
            // Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!"); 
            // Console.Write("\nPress any key to exit..."); 
            // Console.ReadKey(true);

            var counter = 0; 
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1; 
            while (max == -1 || counter < max) 
            { 
                Console.WriteLine($"Counter: {++counter}"); 
                await Task.Delay(1000); 
            }
        }
    }
}
