using System.Collections.Generic;
using Newtonsoft.Json;

namespace HonoursProject.Models
{

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]

    public class PriceChange
    {
        [JsonProperty(PropertyName = "direction")]
        public string direction { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string date { get; set; }

        [JsonProperty(PropertyName = "percent")]
        public string percent { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string price { get; set; }
    }

    public class PriceChangeSummary
    {
        [JsonProperty(PropertyName = "direction")]
        public string direction { get; set; }

        [JsonProperty(PropertyName = "percent")]
        public string percent { get; set; }

        [JsonProperty(PropertyName = "last_updated_date")]
        public string last_updated_date { get; set; }
    }

    public class MinFloorArea
    {
        [JsonProperty(PropertyName = "value")]
        public double value { get; set; }

        [JsonProperty(PropertyName = "units")]
        public string units { get; set; }
    }

    public class FloorArea
    {
        [JsonProperty(PropertyName = "min_floor_area")]
        public MinFloorArea min_floor_area { get; set; }
    }

    public class Listing
    {
        [JsonProperty(PropertyName = "country_code")]
        public string country_code { get; set; }

        [JsonProperty(PropertyName = "num_floors")]
        public string num_floors { get; set; }

        [JsonProperty(PropertyName = "image_150_113_url")]
        public string image_150_113_url { get; set; }

        [JsonProperty(PropertyName = "listing_status")]
        public string listing_status { get; set; }

        [JsonProperty(PropertyName = "num_bedrooms")]
        public string num_bedrooms { get; set; }

        [JsonProperty(PropertyName = "location_is_approximate")]
        public int location_is_approximate { get; set; }

        [JsonProperty(PropertyName = "image_50_38_url")]
        public string image_50_38_url { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public double latitude { get; set; }

        [JsonProperty(PropertyName = "furnished_state")]
        public object furnished_state { get; set; }

        [JsonProperty(PropertyName = "agent_address")]
        public string agent_address { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string category { get; set; }

        [JsonProperty(PropertyName = "property_type")]
        public string property_type { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public double longitude { get; set; }

        [JsonProperty(PropertyName = "thumbnail_url")]
        public string thumbnail_url { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }

        [JsonProperty(PropertyName = "post_town")]
        public string post_town { get; set; }

        [JsonProperty(PropertyName = "details_url")]
        public string details_url { get; set; }

        [JsonProperty(PropertyName = "short_description")]
        public string short_description { get; set; }

        [JsonProperty(PropertyName = "outcode")]
        public string outcode { get; set; }

        [JsonProperty(PropertyName = "image_645_430_url")]
        public string image_645_430_url { get; set; }

        [JsonProperty(PropertyName = "county")]
        public string county { get; set; }

        [JsonProperty(PropertyName = "price")]
        public double price { get; set; }

        [JsonProperty(PropertyName = "listing_id")]
        public string listing_id { get; set; }

        [JsonProperty(PropertyName = "image_caption")]
        public string image_caption { get; set; }

        [JsonProperty(PropertyName = "image_80_60_url")]
        public string image_80_60_url { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "agent_name")]
        public string agent_name { get; set; }

        [JsonProperty(PropertyName = "num_recepts")]
        public string num_recepts { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }

        [JsonProperty(PropertyName = "first_published_date")]
        public string first_published_date { get; set; }

        [JsonProperty(PropertyName = "displayable_address")]
        public string displayable_address { get; set; }

        [JsonProperty(PropertyName = "price_modifier")]
        public string price_modifier { get; set; }

        [JsonProperty(PropertyName = "floor_plan")]
        public List<string> floor_plan { get; set; }

        [JsonProperty(PropertyName = "street_name")]
        public string street_name { get; set; }

        [JsonProperty(PropertyName = "num_bathrooms")]
        public string num_bathrooms { get; set; }

        [JsonProperty(PropertyName = "agent_logo")]
        public string agent_logo { get; set; }

        [JsonProperty(PropertyName = "price_change")]
        public List<PriceChange> price_change { get; set; }

        [JsonProperty(PropertyName = "agent_phone")]
        public string agent_phone { get; set; }

        [JsonProperty(PropertyName = "image_354_255_url")]
        public string image_354_255_url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string image_url { get; set; }

        [JsonProperty(PropertyName = "last_published_date")]
        public string last_published_date { get; set; }

        [JsonProperty(PropertyName = "floor_area")]
        public FloorArea floor_area { get; set; }

        [JsonProperty(PropertyName = "letting_fees")]
        public string letting_fees { get; set; }

    }

    public class BoundingBox
    {
        [JsonProperty(PropertyName = "longitude_min")]
        public string longitude_min { get; set; }

        [JsonProperty(PropertyName = "latitude_min")]
        public string latitude_min { get; set; }

        [JsonProperty(PropertyName = "longitude_max")]
        public string longitude_max { get; set; }

        [JsonProperty(PropertyName = "latitude_max")]
        public string latitude_max { get; set; }
    }

    public class PropertyResult
    {
        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }

        [JsonProperty(PropertyName = "result_count")]
        public int result_count { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public double longitude { get; set; }

        [JsonProperty(PropertyName = "area_name")]
        public string area_name { get; set; }

        [JsonProperty(PropertyName = "listing")]
        public List<Listing> listing { get; set; }

        [JsonProperty(PropertyName = "street")]
        public string street { get; set; }

        [JsonProperty(PropertyName = "town")]
        public string town { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public double latitude { get; set; }

        [JsonProperty(PropertyName = "county")]
        public string county { get; set; }

        [JsonProperty(PropertyName = "bounding_box")]
        public BoundingBox bounding_box { get; set; }

        [JsonProperty(PropertyName = "postcode")]
        public string postcode { get; set; }
    }
}