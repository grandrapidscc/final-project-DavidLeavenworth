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
        private int _hp; // 100 hp
        private int _mp; // 200 mp

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
                // either need to make the array of room objects have a 1 room parimeter that acts as walls, or check for out of bounds based on the array itself
            return _playerLocation;
        }

        public void takeDamage(int damage)
        {
            _hp = _hp - damage;
            
            if(_hp <= 0) 
            {
                Console.WriteLine("The wizart has been slain");
                // back to begining
            }

        }

        public void Fireball() 
        {
            if (_mp <= 0)
                Console.WriteLine("not enough MP");
            else
            {
                Console.WriteLine("fireball");
                _mp = _mp - 3;
            }
            //does 5 damage
            //3mp cost
        }

        public void Heal()
        {
            if (_mp <= 0)
                Console.WriteLine("not enough MP");
            else
            {
                Console.WriteLine("heal");
                _mp = _mp - 5;
                //heals 3 hp
                // 5 mp cost
            }
        }

        public void Flee()
        {
                Console.WriteLine("Runs away");
            // runs away
            // no mp cost
            // message of if he did or did not escape, then a navigation
        }
    }
}
