using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy("Ryan", "McNair");
            lunchBuddy.eat();
            lunchBuddy.eat("burrito");
            lunchBuddy.eat(new List<LunchBuddy>
            {
                new LunchBuddy("Macho", "Man"),
                new LunchBuddy("Ultimate", "Warrior")
            });
            lunchBuddy.eat("corn dogs", new List<LunchBuddy>
            {
                new LunchBuddy("Hulk", "Hogan"),
                new LunchBuddy("Andre", "the Giant")
            });

   
        }
    }
}
