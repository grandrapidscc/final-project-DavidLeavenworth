using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Player
    {
        
        private int _playerlocation;
        private int _hp;
        private int _mp;

        public int playerLocation()
        { 
            return _playerLocation;
        }

        public int playerMovement(int direction)
        {
            if (direction == 1) 
            { 
            }
            if (direction == 2) 
            { 
            }
            if (direction == 3)
            {
            }
            else
                // need to work out how to cleanly move in a grid
            return _playerLocation;
        }

        public int fireball() 
        {
            //does 5 damage
        }

        public int heal()
        { 
            //heals 3 hp
        }

        public void flee()
        {
            // runs away
        }
    }
}
