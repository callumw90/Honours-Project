using System;
using System.Net;
using Newtonsoft.Json;
using HonoursProject.Models;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;

namespace HonoursProject.Services
{
    public class GetData
    {
        public static List<Cocktails> Deserialize()
        {
            string url = "https://raw.githubusercontent.com/teijo/iba-cocktails/master/recipes.json"; //json source

            var client = new WebClient();
            var content = client.DownloadString(url); //connect to web service and retrieve json

            var cocktailJson = JsonConvert.DeserializeObject <List<Cocktails>>(content); //convert json to object

            Analytics.TrackEvent("Loading JSON");

            return cocktailJson;
        }
    }
}
