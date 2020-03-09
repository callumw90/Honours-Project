using System;
using Xamarin.Essentials;
using System.Net;
using Newtonsoft.Json;
using HonoursProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HonoursProject.Services
{
    public class GetData
    {
        public static async Task<List<Listing>> Deserialize()
        {

            var location = await GetLocation();

            //Console.WriteLine(location);

            string url = "https://api.zoopla.co.uk/api/v1/property_listings.json?latitude=" + location.Latitude + "&longitude=" + location.Longitude + "&radius=10&order_by=age&listing_status=sale&page_size=50&description_style=1&api_key=INSERT_API_HERE"; //json source

            var client = new WebClient();
            var content = client.DownloadString(url); //connect to web service and retrieve json

            PropertyResult result = JsonConvert.DeserializeObject<PropertyResult>(content);

            var listingResult = result.listing;

            //Analytics.TrackEvent("Loading JSON");

            return listingResult;
        }

        public static async Task<Location> GetLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var currentLocation = await Geolocation.GetLocationAsync(request);

                return currentLocation;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Location Exception: " + ex);
                return null;
            }
        }
    }
}
