using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
   public class Weapon: Gameitem
    {
   
        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }    
        public double WeaponWeight { get; set; }

        public Weapon(int typeID, string name, int price, int minDamage, int maxDamage, double weaponWeight)
        : base(typeID, name, price, true)
        {
            MaximumDamage = maxDamage;
            MinimumDamage = minDamage;
            WeaponWeight = weaponWeight;
        }

        public new Weapon Clone()
        {
            return new Weapon(TypeID, Name, Price, MinimumDamage, MaximumDamage, WeaponWeight);
        }

    }
}
