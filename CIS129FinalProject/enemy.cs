using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Enemy
    {
        private string _enemyName;
        private int _hp;
        private string _attackName;
        private int _attackDamage;



        public Enemy(string enemyname, int hp, string attackName, int attackDamage)
        {
            _enemyName = enemyname;
            _hp = hp;
            _attackName = attackName;
            _attackDamage = attackDamage;
        }

        public string GetName()
        {
            return _enemyName;
        }

        public string GetAttackName() 
        { 
            return _attackName;
        }

        public int GetAttackDmg()
        { return _attackDamage; }

        public int GetHP()
        {
            return _hp;
        }


        public void TakeDamage(int damage)
        {
            _hp = _hp - damage;

            if (_hp <= 0)
            {
                Console.WriteLine("The enemy has been slain!");
            }
        }



        public int Attack(string _enemyName, string _attackName, int _attackDamage)
        {
            string enemyNameHolder = _enemyName;
            string attackNameHolder = _attackName;
            int attackDamageHolder = _attackDamage;

            Console.WriteLine($"{enemyNameHolder} attacks the wizart with {attackNameHolder}! It deals {attackDamageHolder} damage!");
            return attackDamageHolder;
        }
    }
}
