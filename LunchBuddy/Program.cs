using System;
using System.Collections.Generic;

namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var LunchBuddies = new List<Buddy>();

            var Jake = new Buddy("Jake", "from State Farm");
            LunchBuddies.Add(Jake);

            var Michelle = new Buddy("Michelle", "Obama");
            LunchBuddies.Add(Michelle);

            var Lisa = new Buddy("Lisa", "Frank");
            LunchBuddies.Add(Lisa);

            var Bruce = new Buddy("Bruce", "Wayne");
            LunchBuddies.Add(Bruce);

            Lisa.eat();
            Jake.eat("pizza");
            Michelle.eat(LunchBuddies);
            Jake.eat("spaghetti", LunchBuddies);
        }
    }
}
