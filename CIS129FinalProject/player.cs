using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Player
    {



        private int _playerlocation = 17;
        private int _hp = 100;
        private int _mp = 200;

        public int GetPlayerLocation()
        { 
            return _playerlocation;
        }

        public void SetPlayerLocation(int playerlocation) 
        {
            _playerlocation = playerlocation;
        }

        public int PlayerMovement(int currentRoom)
        {
            Console.WriteLine("Where would you like to move? \nEnter your choice:\n1:North \n2:East \n3:West \n4:South\n");
            var response = Convert.ToInt32(Console.ReadLine());

            if (response == 1 && (currentRoom != 1) && (currentRoom != 2) && (currentRoom != 3) && (currentRoom != 4) && (currentRoom != 5)) //north
            {
                Console.WriteLine("You move north");
                return currentRoom - 5;
            }
            else if (response == 2 && (currentRoom != 5) && (currentRoom != 10) && (currentRoom != 15) && (currentRoom != 20) && (currentRoom != 25)) //east
            {
                Console.WriteLine("You move east");
                return currentRoom + 1;
            }
            else if (response == 3 && (currentRoom != 1) && (currentRoom != 6) && (currentRoom != 11) && (currentRoom != 16) && (currentRoom != 21))//west
            {
                Console.WriteLine("You move west");
                return currentRoom - 1;
            }
            else if (response == 4 && (currentRoom != 21) && (currentRoom != 22) && (currentRoom != 23) && (currentRoom != 24) && (currentRoom != 25))//south
            {
                Console.WriteLine("You move south");
                return currentRoom + 5;
            }
            else if(response == null)
            {
                Console.WriteLine("please enter a number.");
                return currentRoom;
            }
            else
            {
                Console.WriteLine("BONK! you hit your head! There is a wall here, try again.");
                return currentRoom;
            }
                
   
            
        }

        public int GetHp() 
        {
            return _hp;
        }
        public int GetMp()
        {
            return _mp;
        }

        public void TakeDamage(int damage)
        {
            _hp = _hp - damage;
            
            if(_hp <= 0) 
            {
                Console.WriteLine("The wizart has been slain");
                
            }

        }


        public int Fireball() 
        {
            if (_mp <= 0)
                Console.WriteLine("not enough MP");
            else
            {
                _mp = _mp - 3;
            }
            return 5; // 5 damage

        }

        public void Heal()
        {
            if (_mp <= 0)
                Console.WriteLine("not enough MP");
            else
            {
                _mp = _mp - 5;
                _hp = _hp + 3;
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

        public void DrinkHPPotion()
        {
            _hp = _hp + 10;
            Console.WriteLine($"You quaff an HP potion! Tastes like cherry! You heal 10HP! Current HP: {_hp}");
        }

        public void DrinkMPPotion()
        {
            _mp = _mp + 20;
            Console.WriteLine($"You quaff an magika potion! Tastes like cotton candy! You regain 20 MP! Current MP: {_mp}");
        }

    }
}
