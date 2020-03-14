using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchBuddy
{
    class Buddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Buddy(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string GetBuddies(List<Buddy> companions)
        {
            var allOtherBuddies = new List<string>();
            foreach (var friend in companions)
            {
                if (friend.FirstName + friend.LastName != FirstName + LastName)
                {
                    allOtherBuddies.Add(friend.FirstName);
                }
            }
            var printBuddies = allOtherBuddies.Count() > 1 ? (string.Join(", ", allOtherBuddies.Take(allOtherBuddies.Count() - 1)) + " and " + allOtherBuddies.Last()) 
                : (allOtherBuddies.FirstOrDefault<string>());
            return printBuddies;
        }

        public Restaurant eat() 
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
            return restaurant;
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void eat(List<Buddy> companions) 
        {
            var restaurant2 = new Restaurant();
            var myBuddies = GetBuddies(companions);
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant2.Name} with {myBuddies}");
        }
        public void eat(string food, List<Buddy> companions)
        {
            var restaurant3 = new Restaurant();
            var allOtherBuddies = new List<string>();
            var myBuddies = GetBuddies(companions);
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at {restaurant3.Name} with {myBuddies}");
        }
    }
}
