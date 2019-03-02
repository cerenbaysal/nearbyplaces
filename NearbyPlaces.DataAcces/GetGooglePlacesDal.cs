using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.DataAccess
{
    public class GetGooglePlacesDal : IGetPlaces
    {
        public List<string> GetPlaces(string latitude, string longitude, string radius)
        {
            List<string> places = new List<string>();

            string googleApiUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch";
            googleApiUrl += "/json?location=" + latitude + "," + longitude + "&radius=" + radius + "&types=restaurant&key=AIzaSyAG8PoYe0gktdubVb5zjQilr-KyVwF_iGA";
            // AIzaSyAG8PoYe0gktdubVb5zjQilr-KyVwF_iGA
            // AIzaSyDN1QX-gWUR-mIYo_D21PNFLHHpNQkIkGU

            //using (var client = new WebClient())
            //using (var stream = client.OpenRead(googleApiUrl))
            //using (var reader = new StreamReader(stream))
            //{
            //    var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadToEnd());
            //    string r = "";
            //    for (int i = 0; i < jObject["results"].Count(); i++)
            //    {
            //        r = (string)jObject["results"][i]["name"] + " - " + (string)jObject["results"][i]["vicinity"];
            //        places.Add(r);
            //    }
            //}

            return places;
        }
    }
}
