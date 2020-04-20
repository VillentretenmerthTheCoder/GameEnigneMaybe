using System;
using System.Collections.Generic;
using System.Text;
using GameEnigneMaybe.Models;

namespace GameEnigneMaybe.Models
{
    class World
    {
        public int Xsize { get; set; }
        public int Ysize { get; set; }

        private List<Location> _locations { get; set; }

        public void AddLocation(int xCords, int yCords, string name, string description)
        {
            Location NewLocation = new Location();
            NewLocation.Description = description;
            NewLocation.Name = name;
            NewLocation.XCoordinate = xCords;
            NewLocation.YCoordinate = yCords;

            _locations.Add(NewLocation);
        }

        public Location LocationAt(int x, int y)
        {
            Location CurrentLocation = null;
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == x && loc.YCoordinate == y)
                {
                    CurrentLocation = loc;
                }   
            }
            return CurrentLocation;
        }

    }
}
