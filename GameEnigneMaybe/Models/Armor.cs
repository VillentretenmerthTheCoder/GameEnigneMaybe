using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    class Armor:Gameitem
    {

         public int ArmorScore { get; set; }
         public int ArmorWeight { get; set; }

        public Armor(int typeId, string name, int price, int armorScore, int armorWeight ) : base(typeId, name, price, true)
            {
                ArmorScore = armorScore;
                ArmorWeight = armorWeight;
            }

    }
}
