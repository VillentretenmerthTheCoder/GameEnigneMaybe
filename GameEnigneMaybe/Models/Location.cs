using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GameEnigneMaybe.Factories;
using GameEnigneMaybe.Models;

namespace GameEnigneMaybe.Models
{
   public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Quest> QuestsAvailable { get; set; }
        
        public List<CreatureEncounter> CreatureInLocation { get; set; }
        public Trader TraderAtLocation { get; set; }

        
        public void AddCreature(int creatureId, int chanceofEncountering)
        {
            if(CreatureInLocation.Exists(i => i.CreatureId == creatureId))
            {
                CreatureInLocation.First(i => i.CreatureId == creatureId).EncounterChance = chanceofEncountering;
            }
            else
            {
                CreatureInLocation.Add(new CreatureEncounter(creatureId, chanceofEncountering));
            }
        }
    
        public Creature GetCreature()
        {
            if(!CreatureInLocation.Any())
            {
                return null;
            }

            int totalChances = CreatureInLocation.Sum(i => i.EncounterChance);
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);
            int Total = 0;

            foreach(CreatureEncounter creatureEncounter in CreatureInLocation)
            {
                Total += creatureEncounter.EncounterChance;
                if(randomNumber <= Total)
                {
                    return CreatureFactory.GetCreature(creatureEncounter.CreatureId);
                }
            }

            return CreatureFactory.GetCreature(CreatureInLocation.Last().CreatureId);
        }
    }
}
