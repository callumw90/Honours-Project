using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HonoursProject.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Cocktails
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "glass")]
        public string Glass { get; set; }

        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "garnish")]
        public string Garnish { get; set; }

        [JsonProperty(PropertyName = "preparation")]
        public string Preparation { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public List<Ingredient> Ingredients { get; set; }
    }

    public class Ingredient
    {
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        [JsonProperty(PropertyName = "ingredient")]
        public string IngredientName { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "special")]
        public string Special { get; set; }
    }
}
