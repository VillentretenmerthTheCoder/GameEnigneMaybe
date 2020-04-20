using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
   public class Gameitem
    {
        public int TypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; set; }

        public Gameitem(int typeId, string name, int price, bool isUnique )
        {
            TypeID = typeId;
            Name = name;
            Price = price;
            IsUnique = isUnique;
        }
    
        public Gameitem Clone()
        {
            return new Gameitem(TypeID, Name, Price, IsUnique);
        }
    
    }
}
