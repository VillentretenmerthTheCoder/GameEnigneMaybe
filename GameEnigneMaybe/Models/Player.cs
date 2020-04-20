using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using GameEnigneMaybe.Models;
using System.Linq;


namespace GameEnigneMaybe
{
    class Player:LivingEntity
    {
        public enum _Class
        {
            Druid,
            Paladin,
            Warrior,
            Rogue,
            Mage,
            Necromancer
        }

        public _Class CharacterClass { get; set; }

        public int Experience { get; set; }
        public int Level { get; set; }
        
        public ObservableCollection<Quest> Quests { get; set; }

        public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, _Class characterClass, int experience, int level):base(name, currentHitPoints, maximumHitPoints, gold)
        {
            CharacterClass = characterClass;
            Experience = experience;
            Level = level;
        }

        public bool HasAllTheItems(List<QuestItemQuantity> Questitems)
        {
            foreach (QuestItemQuantity Item in Questitems)
            {
                if (Inventory.Count(i => i.TypeID == Item.ItemID) < Item.Quantity)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
