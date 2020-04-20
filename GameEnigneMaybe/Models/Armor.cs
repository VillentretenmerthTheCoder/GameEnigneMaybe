using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    class Armor:Gameitem
    {

         public int ArmorScore { get; set; }
         public double ArmorWeight { get; set; }

        public Armor(int typeId, string name, int price, int armorScore, double armorWeight ) : base(typeId, name, price, true)
            {
                ArmorScore = armorScore;
                ArmorWeight = armorWeight;
            }


        public new Armor Clone()
        {
            return new Armor(TypeID, Name, Price, ArmorScore, ArmorWeight);
        }
    }
}
