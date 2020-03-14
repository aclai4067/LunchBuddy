using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddy
{
    class Restaurant
    {
        private List<string> RestaurantNames => new List<string> 
        { 
            "JimBob's Kuntry Cookin",
            "Chili's", "Mas Tacos",
            "Saint Anejo",
            "Wendy's",
            "Clawsons",
            "Nectar" 
        };
        public string Name { get; }
        Random _rng = new Random();


        public Restaurant()
        {
            Name = RestaurantNames[_rng.Next(RestaurantNames.Count )];
        }
    }
}
