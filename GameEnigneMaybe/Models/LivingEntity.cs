using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using GameEnigneMaybe.Models;
using System.Linq;
using GameEnigneMaybe.Models;

namespace GameEnigneMaybe
{
    public class LivingEntity
    {
        public string Name { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int Gold { get; set; }

        //public event EventHandler OnKilled;
        public bool IsDead => CurrentHitPoints <= 0;

        public ObservableCollection<Gameitem> Inventory { get; set; }
        public ObservableCollection<GroupedInventory> GroupedInventory { get; set; }
        public List<Gameitem> Weapons => Inventory.Where(i => i is Weapon).ToList();
        public List<Gameitem> Armors => Inventory.Where(i => i is Armor).ToList();
            
        protected LivingEntity(string name, int currentHitPoints, int maximumHitPoints, int gold)
        {
            Inventory = new ObservableCollection<Gameitem>();
            Name = name;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            Gold = gold;
        }


        public void TakeDamage(int hitPointsOfDamage)
        {
            CurrentHitPoints -= hitPointsOfDamage;

            if (IsDead)
            {
                CurrentHitPoints = 0;
            }
        }

        public void Heal(int hitPointsToHeal)
        {
            CurrentHitPoints += hitPointsToHeal;

            if (CurrentHitPoints > MaximumHitPoints)
            {
                CurrentHitPoints = MaximumHitPoints;
            }
        }

        public void CompletelyHeal()
        {
            CurrentHitPoints = MaximumHitPoints;
        }

        public void ReceiveGold(int amountOfGold)
        {
            Gold += amountOfGold;
        }

        public void SpendGold(int amountOfGold)
        {
            if (amountOfGold > Gold)
            {
                throw new ArgumentOutOfRangeException($"{Name} only has {Gold} gold, and cannot spend {amountOfGold} gold");
            }

            Gold -= amountOfGold;
        }
        public void AddItemToInventory(Gameitem item)
        {
            Inventory.Add(item);
            if (item.IsUnique)
            {
                GroupedInventory.Add(new GroupedInventory(item, 1));
            }
            else
            {
                if (!GroupedInventory.Any(gi => gi.Item.TypeID == item.TypeID))
                {
                    GroupedInventory.Add(new GroupedInventory(item, 0));
                }

                GroupedInventory.First(gi => gi.Item.TypeID == item.TypeID).Quantity++;
            }
        }

        public void RemoveItemFromInventory(Gameitem item)
        {
            Inventory.Remove(item);

            GroupedInventory itemToRemove =
                GroupedInventory.FirstOrDefault(gi => gi.Item == item);

            if (itemToRemove != null)
            {
                if (itemToRemove.Quantity == 1)
                {
                    GroupedInventory.Remove(itemToRemove);
                }
                else
                {
                    itemToRemove.Quantity--;
                }
            }
        }
    }
}
