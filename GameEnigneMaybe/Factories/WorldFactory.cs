using System;
using System.Collections.Generic;
using System.Text;
using GameEnigneMaybe.Models;

namespace GameEnigneMaybe.Factories
{
    public static class WorldFactory
    {
        static World CreateWorld()
        {
            World newworld = new World();
            newworld.AddLocation(1, 2, "Garden", "Garden full of flowers, there is a strange man sitting under the tree. Maybe you should talk to him?");
            newworld.LocationAt(1, 2).AddCreature(1, 75);
            newworld.AddLocation(5, 6, "Lonely House", "It is a lonely house. You may find something usefull inside.");
            newworld.LocationAt(5, 6).AddCreature(3, 100);
            newworld.LocationAt(5, 6).TraderAtLocation = TraderFactory.GetTraderByName("Susan");

            return newworld;
        }
    }
}
