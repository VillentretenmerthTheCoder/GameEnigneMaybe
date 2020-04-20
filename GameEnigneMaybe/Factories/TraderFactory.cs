using System;
using System.Collections.Generic;
using System.Text;
using GameEnigneMaybe.Models;
using System.Linq;

namespace GameEnigneMaybe.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader susan = new Trader("Susan");
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1));

            Trader farmerTed = new Trader("Farmer Ted");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2));

            Trader peteHerbalist = new Trader("Pete the Herbalist");
            peteHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3));

            AddTraderToList(susan);
            AddTraderToList(farmerTed);
            AddTraderToList(peteHerbalist);

        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(x => x.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(x => x.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader with that name!");
            }
            _traders.Add(trader);
        }
    }
}
