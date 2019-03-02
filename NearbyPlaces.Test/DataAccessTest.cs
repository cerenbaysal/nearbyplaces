using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NearbyPlaces.Business;
using System.Collections.Generic;

namespace NearbyPlaces.Test
{
    [TestClass]
    public class DataAccessTest
    {
        IGetCachePlaces _getCachePlaces;
        IGetGooglePlaces _getGooglePlaces;

        [TestMethod]
        public void GetCachePlaces()
        {
            string latitude = "41.0680321";
            string longitude = "28.9899774";
            string radius = "500";

            List<string> places = _getCachePlaces.Get(latitude, longitude, radius);
        }

        [TestMethod]
        public void GetGooglePlaces()
        {
            string latitude = "41.0680321";
            string longitude = "28.9899774";
            string radius = "500";

            List<string> places = _getGooglePlaces.Get(latitude, longitude, radius);
        }
    }
}
