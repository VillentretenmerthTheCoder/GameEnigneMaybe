using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    public class CreatureEncounter
    {
        public int CreatureId { get; set; }
        public int EncounterChance { get; set; }

        public CreatureEncounter(int creatureId, int encounterChance)
        {
            CreatureId = creatureId;
            EncounterChance = encounterChance;
        }
    }
}
