using NearbyPlaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.TestApplication
{
    static class Program
    {
        static void Main(string[] args)
        {
            GetCachePlacesDal getCachePlacesDal = new GetCachePlacesDal();
            //List<string> places = new List<string>();
            //places.Add("test1");
            //places.Add("test2");
            //getCachePlacesDal.InsertPlaces("41.0680321", "28.9899774", places);
            List<string> getPlaces = getCachePlacesDal.GetPlaces("41.0680321", "28.9899774", "500");
            
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
