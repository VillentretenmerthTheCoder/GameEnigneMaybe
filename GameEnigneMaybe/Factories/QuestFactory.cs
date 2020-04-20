using System;
using System.Collections.Generic;
using System.Text;
using GameEnigneMaybe.Models;
using System.Linq;

namespace GameEnigneMaybe.Factories
{
   public static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

         static QuestFactory()
         {
            //Declare the items need to complete the quest and its rewards.
            List<QuestItemQuantity> itemsToComplete = new List<QuestItemQuantity>();
            List<QuestItemQuantity> rewardItems = new List<QuestItemQuantity>();


            itemsToComplete.Add(new QuestItemQuantity(7, 3));
            rewardItems.Add(new QuestItemQuantity(2, 1));

            //Create quest here.

            _quests.Add(new Quest(
                1, "Clear the herb garden", "Defeat the snakes in the Herbalist's garden", itemsToComplete, 25, 10, rewardItems));
         }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
