using System;
using System.Collections.Generic;

namespace HonoursProject.Models
{
    public class Ingredient
    {
        public string unit { get; set; }
        public double amount { get; set; }
        public string ingredient { get; set; }
        public string label { get; set; }
        public string special { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string glass { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public string garnish { get; set; }
        public string preparation { get; set; }
        public string imageUri { get; set; }
    }
}