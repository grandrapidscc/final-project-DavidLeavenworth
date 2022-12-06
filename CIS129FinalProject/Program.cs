
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace CIS129FinalProject;


class Program
{
    static void Main(String[] args)
    {
        Narrator narration = new Narrator();
        Encounter encounter = new Encounter();
        Player player = new Player();
        Enemy goblin = new Enemy("Goblin", 3, "Body Slam", 2);
        Enemy orc = new Enemy("Orc", 5, "Cleave", 3);
        Enemy banshee = new Enemy("Banshee", 8, "Screech", 5);

        int currentRoomHolder;
        int newPlayerLocation = 0;

        //int playerHP = player.GetHp();
        //int playerMP = player.GetMp();

        //1 2 3 4 5
        //6 7 8 9 10
        //11 12 13 14 15
        //16 17 18 19 20
        //21 22 23 24 25

        //start room 17 end room 10
        /*
            int roomNumberForDiscription,x
            bool hasPlayer, x
            bool hasExit,x 
            bool hasGoblin,
            bool hasOrc, 
            bool hasBanshee, 
            bool hasHPPotion, 
            bool HasMPPotion, 
            bool isWallToNorth, X
            bool isWallToSouth, X
            bool isWallToWest,X
            bool isWallToEast) X
         */

        // Room declaration
        Room Room1 = new Room(1, false, false, false, false, false, true, false, true, false, true, false);
        Room Room2 = new Room(2, false, false, false, true, false, false, true, true, false, false, false);
        Room Room3 = new Room(3, false, false, false, false, true, true, false, true, false, false, false);
        Room Room4 = new Room(4, false, false, true, false, false, false, false, true, false, false, false);
        Room Room5 = new Room(5, false, false, false, false, false, false, true, true, false, false, true);
        Room Room6 = new Room(6, false, false, false, false, true, false, false, false, false, true, false);
        Room Room7 = new Room(7, false, false, true, false, false, false, false, false, false, false, false);
        Room Room8 = new Room(8, false, false, false, true, false, false, false, false, false, false, false);
        Room Room9 = new Room(9, false, false, false, false, false, false, false, false, false, false, false);
        Room Room10 = new Room(10, false, true, false, false, false, false, false, false, false, false, true);
        Room Room11 = new Room(11, false, false, false, true, false, false, false, false, false, true, false);
        Room Room12 = new Room(12, false, false, false, false, true, false, false, false, false, false, false);
        Room Room13 = new Room(13, false, false, false, false, false, true, false, false, false, false, false);
        Room Room14 = new Room(14, false, false, true, false, false, false, false, false, false, false, false);
        Room Room15 = new Room(15, false, false, false, true, false, false, false, false, false, false, true);
        Room Room16 = new Room(16, false, false, true, false, false, false, false, false, false, true, false);
        Room Room17 = new Room(17, true, false, false, false, false, false, false, false, false, false, false);
        Room Room18 = new Room(18, false, false, true, false, false, false, false, false, false, false, false);
        Room Room19 = new Room(19, false, false, false, false, false, true, false, false, false, false, false);
        Room Room20 = new Room(20, false, false, false, false, false, false, false, false, false, false, true);
        Room Room21 = new Room(21, false, false, false, false, false, true, false, false, true, true, false);
        Room Room22 = new Room(22, false, false, false, false, true, false, false, false, true, false, false);
        Room Room23 = new Room(23, false, false, false, false, false, false, false, false, true, false, false);
        Room Room24 = new Room(24, false, false, false, true, false, false, false, false, true, false, false);
        Room Room25 = new Room(25, false, false, false, false, false, true, false, false, true, false, true);

        //creation of the dungeon from the rooms
        Room[,] Dungeon =
        {
            {Room1, Room2, Room3, Room4, Room5},
            {Room6, Room7, Room8, Room9, Room10},
            {Room11, Room12, Room13, Room14, Room15},
            {Room16, Room17, Room18, Room19, Room20},
            {Room21, Room22, Room23, Room24, Room25},
        };


        bool gameover = false;

        Console.WriteLine("Welcome to wizart!");

        while (gameover == false)
        {
            int playerLocation = 17;
            int endLocation = 10;

            foreach (Room room in Dungeon)
            {

                if (room._hasPlayer)
                {
                    currentRoomHolder = room._roomNumberForDiscription;

                    narration.StartNarration(room._roomNumberForDiscription);
                    //then do the encounter if any
                    //then potions,
                    //then directionality, change the room info, change playerLocation
                    player.TakeDamage(encounter.Fight
                        (
                        room._hasGoblin,
                        room._hasOrc,
                        room._hasBanshee,
                        goblin.GetName(),
                        goblin.GetHP(),
                        goblin.GetAttackName(),
                        goblin.GetAttackDmg(),
                        orc.GetName(),
                        orc.GetHP(),
                        orc.GetAttackName(),
                        orc.GetAttackDmg(),
                        banshee.GetName(),
                        banshee.GetHP(),
                        banshee.GetAttackName(),
                        banshee.GetAttackDmg()
                        ));
                    //cleanup combat
                    if (room._hasGoblin)
                    {
                        room._hasGoblin = false;
                    }
                    if(room._hasOrc) 
                    { 
                        room._hasOrc = false;
                    }
                    if (room._hasBanshee)
                    {
                        room._hasBanshee = false;
                    }
                    //cleanup items
                    if (room._hasHPPotion)
                    {
                        narration.itemNarration();
                        player.DrinkHPPotion();
                        room._hasHPPotion = false;
                    }
                    if (room._hasMPPotion)
                    {
                        narration.itemNarration();
                        player.DrinkMPPotion();
                        room._hasMPPotion = false;
                    }


                    Console.WriteLine($"Wizart's current stats: HP:{player.GetHp()} MP:{player.GetMp()}");

                    newPlayerLocation = player.PlayerMovement(currentRoomHolder);
                    playerLocation = newPlayerLocation;
                    // from here save the int, change the player to that room, remove the old player info
                    room._hasPlayer = false;



                }

                if (room._roomNumberForDiscription == newPlayerLocation)
                {
                    room._hasPlayer = true;
                }

                if (playerLocation == endLocation)
                {
                    Console.WriteLine("You win! Would you like to play again? : 1 = yes / 2 = no");
                    int userResponse = Convert.ToInt32(Console.ReadLine());
                    if (userResponse == 1)
                    {
                        Room10._hasPlayer = false;
                        Room17._hasPlayer = true;
                        break;
                    }
                    else if (userResponse == 2)
                    {
                        gameover = true;
                        break;
                    }
                }
            }
        }
    }
}