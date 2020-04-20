using System;
using System.Collections.Generic;
using System.Text;
using GameEnigneMaybe.Models;
using System.Linq;

namespace GameEnigneMaybe.Factories
{
    static class ItemFactory
    {
        private static List<Gameitem> _gameitems { get; set; }

        static ItemFactory()
        {
            _gameitems.Add(new Weapon(1, "Stick of Nothing", 0, 0, 5, 0.5));
            _gameitems.Add(new Weapon(2, "Rusty Sword of Misery", 5, 5, 10, 3));
            _gameitems.Add(new Weapon(3, "The Bow of Madness", 20, 10, 20, 2));
            _gameitems.Add(new Weapon(4, "The Sling of Redemption", 15, 8, 15, 1));
            _gameitems.Add(new Armor(5, "The Pot Helmet", 5, 5, 2));
            _gameitems.Add(new Armor(6, "The Harness of Uselessness ", 15, 10, 4));
            _gameitems.Add(new Gameitem(7, "Rat Tail", 2, false));
            _gameitems.Add(new Gameitem(8, "Spider Silk", 3, false));
            _gameitems.Add(new Potion(9, "Potion of Fortified Health", 30, 15, Potion._potionType.Fortify));
            _gameitems.Add(new Potion(10, "Cadaveric poison", 50, 10, Potion._potionType.Posion));
            _gameitems.Add(new Potion(11, "Lesser Potion of Health", 15, 10, Potion._potionType.Healing));
            _gameitems.Add(new Potion(12, "Golden Potion", 200, 200, Potion._potionType.Golden));
            _gameitems.Add(new Potion(13, "Potion of Lesser Experience", 100, 30, Potion._potionType.Experience));
        }
        public static Gameitem CreateGameItem(int id)
        {
            Gameitem standardItem = _gameitems.FirstOrDefault(item => item.TypeID == id);
            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                else if(standardItem is Armor)
                {
                    return (standardItem as Armor).Clone();
                }

                return standardItem.Clone();
            }

            return null;
        }
    }
}
