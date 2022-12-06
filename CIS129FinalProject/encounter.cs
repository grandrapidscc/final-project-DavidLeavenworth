using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CIS129FinalProject
{
    public class Encounter
    {
        // this will contain the logic of an encounter ie if the player, an enemy and powerup are all in the same room, folowing the player, 
        //determines order of operations
        // intro narritive, fight, item consumption, cleanup/removal of item and monster from room, navigation narritive, navigation.

        Enemy goblin1 = new Enemy("Goblin", 3, "Body Slam", 2);
        Enemy orc1 = new Enemy("Orc", 5, "Cleave", 3);
        Enemy banshee1 = new Enemy("Banshee", 8, "Screech", 5);

        Player player = new Player();



        public int Fight
            (
            bool hasGoblin, 
            bool hasOrc, 
            bool hasBanshee, 
            string gobName, 
            int gobHP,
            string gobAttackName,
            int gobAttackDmg,
            string orcName,
            int orcHP,
            string orcAttackName,
            int orcAttackDmg, 
            string banName,
            int banHP,
            string banAttackName,
            int banAttackDmg
            )
        {
            bool isGoblin = hasGoblin;
            bool isOrc = hasOrc;
            bool isBanshee = hasBanshee;
            string isGobName = gobName;
            int isGobHP = gobHP;
            string isGobAttackName = gobAttackName;
            int isGobAttackDmg = gobAttackDmg;
            string isOrcName = orcName;
            int isOrcHP = orcHP;
            string isOrcAttackName = orcAttackName;
            int isOrcAttackDmg = orcAttackDmg;
            string isBanName = banName;
            int isBanHP = banHP;
            string isBanAttackName = banAttackName;
            int isBanAttackDmg = banAttackDmg;

            int DamageToPlayer = 0;

            if( isGoblin ) 
            {
                Console.WriteLine("You encounter a goblin!");
                while (goblin1.GetHP() >= 0)
                {
                    goblin1.Attack(isGobName, isGobAttackName, isGobAttackDmg);
                    DamageToPlayer = DamageToPlayer + isGobAttackDmg;
                    Console.WriteLine($"The goblin looks menacing! It's HP is {gobHP}");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("press the corresponding key to choose an action: \n1 : Fireball\n2 : Heal\n3 : Flee");
                    var response = Convert.ToInt32(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.WriteLine("You cast a mighty fireball!");
                        goblin1.TakeDamage(player.Fireball());
                        gobHP = gobHP - 5;
                    }
                    else if (response == 2)
                    {
                        Console.WriteLine("You cast heal! Your wounds knit together!");
                        player.Heal();
                    }
                    else
                    {
                        Console.WriteLine("You attempt to flee!");
                        Console.WriteLine("You cant escape!");
                    }
                    
                }
                return DamageToPlayer;
            }

            else if(isOrc)
            {
                Console.WriteLine("You encounter an orc!");
                while (orc1.GetHP() >= 0)
                {
                    orc1.Attack(isOrcName, isOrcAttackName, isOrcAttackDmg);
                    DamageToPlayer = DamageToPlayer + isOrcAttackDmg;
                    Console.WriteLine($"The orc looks hungry! It's HP is {orcHP}");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("press the corresponding key to choose an action: \n1 : Fireball\n2 : Heal\n3 : Flee");
                    var response = Convert.ToInt32(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.WriteLine("You cast a mighty fireball!");
                        orc1.TakeDamage(player.Fireball());
                        orcHP = orcHP - 5;
                    }
                    else if (response == 2)
                    {
                        Console.WriteLine("You cast heal! Your wounds knit together!");
                        player.Heal();
                    }
                    else
                    {
                        Console.WriteLine("You attempt to flee!");
                        Console.WriteLine("You cant escape!");
                    }
                    


                }
                return DamageToPlayer;
            }

            else if (isBanshee)
            {
                Console.WriteLine("You encounter a banshee!");
                while (banshee1.GetHP() >= 0)
                {
                    banshee1.Attack(isBanName, isBanAttackName, isBanAttackDmg);
                    DamageToPlayer = DamageToPlayer + isBanAttackDmg;
                    Console.WriteLine($"The banshee looks loud!  It's HP is {banHP}");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("press the corresponding key to choose an action: \n1 : Fireball\n2 : Heal\n3 : Flee");
                    var response = Convert.ToInt32(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.WriteLine("You cast a mighty fireball!");
                        banshee1.TakeDamage(player.Fireball());
                        banHP= banHP - 5;
                    }
                    else if (response == 2)
                    {
                        Console.WriteLine("You cast heal! Your wounds knit together!");
                        player.Heal();
                    }
                    else
                    {
                        Console.WriteLine("You attempt to flee!");
                        Console.WriteLine("You cant escape!");
                    }
                }
                return DamageToPlayer;
            }
            else
            {
                Console.WriteLine("You see no monster! You breath a sigh of relief.");
                return DamageToPlayer;
            }
        }
    }
}
