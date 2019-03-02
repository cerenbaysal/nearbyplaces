using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Business
{
    public interface IGetGooglePlaces
    {
        List<string> Get(string latitude, string longitude, string radius);
    }
}
