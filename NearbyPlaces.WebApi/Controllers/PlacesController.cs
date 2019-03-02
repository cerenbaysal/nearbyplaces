using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NearbyPlaces.WebApi.Models;
using System.Web.Http;
using NearbyPlaces.Business;
using System.Web.Http.Cors;

namespace NearbyPlaces.WebApi.Controllers
{
    public class PlacesController : ApiController
    {
        private readonly IGetGooglePlaces _getGooglePlaces;
        private readonly IGetCachePlaces _getCachePlaces;

        public PlacesController(IGetGooglePlaces getGooglePlaces, IGetCachePlaces getCachePlaces)
        {
            _getGooglePlaces = getGooglePlaces;
            _getCachePlaces = getCachePlaces;
        }

        // GET: Places
        [System.Web.Http.HttpGet]
        public GetPlacesResponse GetNearbyPlaces(string latitude, string longitude, string radius)
        {
            GetPlacesResponse response = new GetPlacesResponse();

            try
            {
                List<string> places = _getCachePlaces.Get(latitude, longitude, radius);

                if (places.Count != 0)
                    response.Places = places;
                else
                {
                    response.Places = _getGooglePlaces.Get(latitude, longitude, radius);
                    _getCachePlaces.Insert(latitude, longitude, radius, response.Places);
                }

                response.ResponseState = Framework.ResponseState.Success;
            }
            catch (Exception ex)
            {
                response.ResponseState = Framework.ResponseState.WithErrors;
                response.ResponseMessage = ex.Message;
            }

            return response;
        }
    }
}