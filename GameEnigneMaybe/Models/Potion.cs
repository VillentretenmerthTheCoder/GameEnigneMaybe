using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    public class Potion:Gameitem
    {
        public int PotionScore { get; set; }
        public enum _potionType
        {
            Healing,
            Posion,
            Fortify,
            Golden,
            Experience
        }

        public _potionType PotionType { get; set; }

        public Potion(int typeId, string name, int price, int potionScore, _potionType potionType):base(typeId,name,price,false)
        {
            PotionScore = potionScore;
            PotionType = potionType;
        }

    }
}
