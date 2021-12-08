using System;
using System.IO;
using Newtonsoft.Json;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var path = Path.Combine(Environment.CurrentDirectory, "info.json");
                var json = File.ReadAllText(path);
                Objects info = JsonConvert.DeserializeObject<Objects>(json);
            }
            catch 
            {
                Console.WriteLine("Error");
            }
            var B = new Shop();
            B.Info();
            Console.WriteLine(B.B);
        }
    }
}