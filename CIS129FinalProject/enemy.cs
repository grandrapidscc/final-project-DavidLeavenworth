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

        // 3 enemys, need to inherit from the base enemy classes
        // goblin orc banshee
        
    }

    public class goblin:enemy
    {
        // 3hp, body slam, 2hp dmg
    }

    public class orc:enemy
    {
        //5hp, cleave, 3hp dmg
    }

    public class banshee : enemy
    {
        //8hp, screetch, 5hp dmg
    }
}
