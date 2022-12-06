using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Room
    {
        // a room must have options for:
        // the player, the exit, enemys, items

        public int _roomNumberForDiscription;
        public bool _hasPlayer;
        public bool _hasExit;
        public bool _hasGoblin;
        public bool _hasOrc;
        public bool _hasBanshee;
        public bool _hasHPPotion;
        public bool _hasMPPotion;
        public bool _isWallToNorth;
        public bool _isWallToSouth;
        public bool _isWallToWest;
        public bool _isWallToEast;



        public Room
            (int roomNumberForDiscription, 
            bool hasPlayer, 
            bool hasExit,
            bool hasGoblin,
            bool hasOrc, 
            bool hasBanshee, 
            bool hasHPPotion, 
            bool HasMPPotion, 
            bool isWallToNorth, 
            bool isWallToSouth, 
            bool isWallToWest, 
            bool isWallToEast)
        {
            _roomNumberForDiscription= roomNumberForDiscription;
            _hasPlayer = hasPlayer;
            _hasExit = hasExit;
            _hasGoblin = hasGoblin;
            _hasOrc = hasOrc;
            _hasBanshee = hasBanshee;
            _hasHPPotion = hasHPPotion;
            _hasMPPotion = HasMPPotion;
            _isWallToNorth = isWallToNorth;
            _isWallToSouth = isWallToSouth;
            _isWallToWest= isWallToWest;
            _isWallToEast= isWallToEast;
        }

    }

}
