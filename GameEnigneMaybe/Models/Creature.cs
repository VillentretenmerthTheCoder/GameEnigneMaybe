using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe
{
    public class Creature: LivingEntity
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int Experience { get; set; }

        public Creature(string name, int currentHitPoints, int maximumHitPoints, int gold, int minimumDamage, int maximumDamage, int experience  ):base(name, currentHitPoints, maximumHitPoints, gold)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            Experience = experience;
        }


    }
}
