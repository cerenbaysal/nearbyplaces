using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.DataAccess
{
    public interface IGetPlaces
    {
        List<string> GetPlaces(string latitude, string longitude, string radius);
    }
}
