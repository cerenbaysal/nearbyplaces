using NearbyPlaces.WebApi.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearbyPlaces.WebApi.Models
{
    public class GetPlacesResponse
    {
        /// <summary>
        /// Places
        /// </summary>
        public List<string> Places { get; set; }

        /// <summary>
        /// Response State
        /// </summary>
        public ResponseState ResponseState { get; set; }

        /// <summary>
        /// Response Message
        /// </summary>
        public string ResponseMessage { get; set; }
    }
}