using System;
using System.Collections.Generic;
using System.Text;

namespace GameEnigneMaybe.Models
{
    public class QuestItemQuantity
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public QuestItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
