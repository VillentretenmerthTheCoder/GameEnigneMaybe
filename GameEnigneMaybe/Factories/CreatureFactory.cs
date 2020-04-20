using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Factories
{
    public static class CreatureFactory
    {
        public static Creature GetCreature(int ID)
        {
            switch (ID)
            {
                case 1:
                    Creature snake = new Creature("Viper", 4, 4, 3, 2, 5, 1);
                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    return snake;
                case 2:
                    Creature rat = new Creature("BIG RATTATOI", 5, 5, 4, 2, 5, 1);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                    return rat;
                case 3:
                    Creature giantSpider = new Creature("Giant Spider", 10, 10, 6, 3, 10, 2);
                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    return giantSpider;
                default:

                    throw new ArgumentException(string.Format("MonsterType'{0}' does not exist",ID));

            }
        }


        private static void AddLootItem(Creature creature, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                creature.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
