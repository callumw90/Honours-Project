using System;
using System.Net;
using Newtonsoft.Json;
using HonoursProject.Models;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using System.Data;

namespace HonoursProject.Services
{
    public class GetData
    {
        public static List<Listing> Deserialize()
        {
            string url = "https://api.zoopla.co.uk/api/v1/property_listings.json?postcode=ky11&listing_status=sale&page_size=50&api_key=bmm77zppverakbnfnmtyuky3"; //json source

            var client = new WebClient();
            var content = client.DownloadString(url); //connect to web service and retrieve json

            PropertyResult result = JsonConvert.DeserializeObject<PropertyResult>(content);

            var listingResult = result.listing;

            Analytics.TrackEvent("Loading JSON");

            return listingResult;
        }
    }
}
