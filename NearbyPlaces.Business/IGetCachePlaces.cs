using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Business
{
    public interface IGetCachePlaces
    {
        List<string> Get(string latitude, string longitude, string radius);

        void Insert(string latitude, string longitude, string radius, List<string> places);
    }
}
