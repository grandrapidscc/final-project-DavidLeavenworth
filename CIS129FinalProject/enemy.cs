using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class enemy
    {
        private string _enemyName;
        private int _hp;
        private int _mp;


        public enemy(string enemyname, int hp, int mp)
        {
            _enemyName = enemyname;
            this.hp = hp;
            this.mp = mp;
        }

        public void takeDamage(int damage)
        {
            _hp = _hp - damage;

            if (_hp <= 0)
            {
                Console.WriteLine("The enemy has been slain");
             
            }

        }


    }

    public class goblin:enemy
    {


        public goblin(string enemyname, int hp, int mp) : base(enemyname, hp, mp)
        {
            enemyName = enemyname;
            _hp = hp;
            _mp = mp;

        }
        public void BodySlam()
        {
            Console.WriteLine("body slam");
        }

        // 3hp, body slam, 2hp dmg
    }

    public class orc:enemy
    {
        private int _hp = 5;

        public void Cleave() 
        {
            Console.WriteLine("cleve");
        }
        //5hp, cleave, 3hp dmg
    }

    public class banshee : enemy
    {
        private int _hp = 8;

        public void Screetch() 
        {
            Console.WriteLine("screetch");
        }
        //8hp, screetch, 5hp dmg
    }
}
