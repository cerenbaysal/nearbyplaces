using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.DataAccess
{
    public class GetCachePlacesDal : IGetPlaces
    {
        public List<string> GetPlaces(string latitude, string longitude, string radius)
        {
            var redis = ConnectionMultiplexer.Connect("nearbyplacesredis.redis.cache.windows.net:6380,password=Bxkqg8Jr9mC35oSzfESy7M1p7o69caLXsOSfJPJ6ghM=,ssl=True,abortConnect=False");
            var db = redis.GetDatabase();
            var key = latitude + ":" + longitude + ":" + radius;

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Include;
            var placesJsonified = db.StringGet(key);

            if (placesJsonified.IsNull)
                return new List<string>();

            var places = JsonConvert.DeserializeObject<List<string>>(placesJsonified);
            return places.ToList<string>();
        }

        public void InsertPlaces(string latitude, string longitude, string radius, List<string> places)
        {
            var redis = ConnectionMultiplexer.Connect("nearbyplacesredis.redis.cache.windows.net:6380,password=Bxkqg8Jr9mC35oSzfESy7M1p7o69caLXsOSfJPJ6ghM=,ssl=True,abortConnect=False");
            var db = redis.GetDatabase();
            var key = latitude + ":" + longitude + ":" + radius;

            var placesJsonified = JsonConvert.SerializeObject(places);
            db.StringSet(key, placesJsonified);
        }
    }
}
