using NearbyPlaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Business
{
    public class GetGooglePlaces : IGetGooglePlaces
    {
        private readonly GetGooglePlacesDal _getGooglePlacesDAL;

        public GetGooglePlaces(GetGooglePlacesDal getGooglePlacesDAL)
        {
            _getGooglePlacesDAL = getGooglePlacesDAL;
        }

        public List<string> Get(string latitude, string longitude, string radius)
        {
            return _getGooglePlacesDAL.GetPlaces(latitude, longitude, radius);
        }
    }
}
