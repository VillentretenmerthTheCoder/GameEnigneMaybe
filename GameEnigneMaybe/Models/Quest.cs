using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<QuestItemQuantity> ItemsToComplete { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List<QuestItemQuantity> RewardItems { get; set; }

        public Quest(int id, string name, string description, List<QuestItemQuantity> itemsToComplete, int rewardExperience, int rewardGold, List<QuestItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
