using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName;
        List<string> restaurants = new List<string>{ "Taco Bell", "Panda Express", "Panera", "Hot Dog on a Stick" };
        
        public Restaurant()
        {
            Random randomRestaurant = new Random();
            int index = randomRestaurant.Next(restaurants.Count);
            RestaurantName = restaurants[index];
        }

        
    }
}
