using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDocumantation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter kilometrs: ");
                double distance = double.Parse(Console.ReadLine());
                Console.WriteLine($"{distance} km= {Distance.KilometersToMiles(distance)}");
                Console.WriteLine("Enter miles: ");
                distance= double.Parse(Console.ReadLine());
                Console.WriteLine($"{distance} miles= {Distance.MilesToKilometers(distance)}");
            }   
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
