using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"My friend {FirstName} {LastName} is meeting me at {restaurant.RestaurantName}");
        }
        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} is having a {food}.");
        }
        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} is meeting me at {restaurant.RestaurantName} with ");
            foreach (var item in companions)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
        public void eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} ate {food} at {restaurant.RestaurantName} with ");
            foreach (var item in companions)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
