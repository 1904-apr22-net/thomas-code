using MySoapConsumer.UnitConversionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoapConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new UnitConversionServiceClient())
            {
                client.Open();
                Console.WriteLine("Enter the measurement in feet to be converted to meters ");
                var feet = int.Parse(Console.ReadLine());
                var meters = client.FeetToMeters(feet);
                Console.WriteLine($"Result is: {meters}");
                client.Close();
            }
            Console.ReadKey();
        }
    }
}
