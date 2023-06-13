﻿using Newtonsoft.Json;

namespace LucianoNicolasArrieta.DrinksApp.Models
{
    public class Drink
    {
        public string IdDrink { get; set; }
        public string StrDrink { get; set; }
    }

    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList { get; set; }
    }
}
