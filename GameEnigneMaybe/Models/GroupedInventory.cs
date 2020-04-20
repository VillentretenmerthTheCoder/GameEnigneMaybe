using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
   public class GroupedInventory
    {
     
        public Gameitem Item { get; set; }
        public int Quantity { get; set; }
      
        public GroupedInventory(Gameitem item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }


    }
}
