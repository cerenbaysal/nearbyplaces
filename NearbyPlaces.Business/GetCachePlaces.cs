using NearbyPlaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Business
{
    public class GetCachePlaces : IGetCachePlaces
    {
        private readonly GetCachePlacesDal _getCachePlacesDAL;

        public GetCachePlaces(GetCachePlacesDal getCachePlacesDAL)
        {
            _getCachePlacesDAL = getCachePlacesDAL;
        }

        public List<string> Get(string latitude, string longitude, string radius)
        {
            return _getCachePlacesDAL.GetPlaces(latitude, longitude, radius);
        }

        public void Insert(string latitude, string longitude, string radius, List<string> places)
        {
            _getCachePlacesDAL.InsertPlaces(latitude, longitude, radius, places);
        }
    }
}
