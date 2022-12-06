using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Narrator
    {
        // this will contain all of the flavor text that will be displayed back to the user when navigating



        // room intro
        // monster and item intro
        // x monster attacks player with y attack for z damage! the player has xx health remaining!
        // what action the player takes
        // x monster is slain
        // player found x potion / drinks floor potions on the spot
        // choosing direction
        // if running into a wall

        //1 2 3 4 5
        //6 7 8 9 10
        //11 12 13 14 15
        //16 17 18 19 20
        //21 22 23 24 25


        public void StartNarration(int roomNumber)
        {
            int numberForNarration = roomNumber;

            switch(numberForNarration)
            {
                    case 1:
                    Console.WriteLine("This is a corner of the dungeon! Walls to the north and west.");
                    break;
                    case 2:
                    Console.WriteLine("There is a wall to the north! The torch sconces are made of bones.");
                    break;
                    case 3:
                    Console.WriteLine("There is a wall to the north! The gloomy atmosphere sends a shiver up your spine!");
                    break;
                    case 4:
                    Console.WriteLine("There is a wall to the north! Something creaks nearby!");
                    break;
                    case 5:
                    Console.WriteLine("This is a corner of the dungeon! Walls to the north and east. ");
                    break;
                    case 6:
                    Console.WriteLine("There is a wall to the west! You hear a haunting noise!");
                    break;
                    case 7:
                    Console.WriteLine("It is pitch dark here. You hear a scraping noise.");
                    break;
                    case 8:
                    Console.WriteLine("The smell of rot is in the air.");
                    break;
                    case 9:
                    Console.WriteLine("You think you hear birds in the distance!");
                    break;
                    case 10:
                    Console.WriteLine("The exit! At last!");
                    break;
                    case 11:
                    Console.WriteLine("There is a wall to the west! The snorting of an Orc gets your hackels up!");
                    break;
                    case 12:
                    Console.WriteLine("You hear a haunting wail!");
                    break;
                    case 13:
                    Console.WriteLine("It is pitch black, you stumble over something!");
                    break;
                    case 14:
                    Console.WriteLine("The floor is littered with bones!");
                    break;
                    case 15:
                    Console.WriteLine("There is a wall to the east! There is a decorative pile of skulls here.");
                    break;
                    case 16:
                    Console.WriteLine("There is a wall to the west! You bravely push on for the exit!");
                    break;
                    case 17:
                    Console.WriteLine("This is the start of your quest out of the dungeon!");
                    break;
                    case 18:
                    Console.WriteLine("You hear chittering all around you!");
                    break;
                    case 19:
                    Console.WriteLine("A skeleton is crumpled in a heap on the floor. Looks like it has been here quite some time!");
                    break;
                    case 20:
                    Console.WriteLine("There is a wall to your east! You feel as if you are going in the wrong direction.");
                    break;     
                    case 21:
                    Console.WriteLine("This is a corner of the dungeon, walls to the south and west!");
                    break;     
                    case 22: 
                    Console.WriteLine("There is a wall to the south! There is a sign that says \"NO WIZARDS ALLOWED\"");
                    break;   
                    case 23:
                    Console.WriteLine("There is a wall to the south! You feel for a secret door, but cannot find one.");
                    break;
                    case 24:
                    Console.WriteLine("There is a wall to the south! An Orc tried to ambush you!");
                    break;
                    case 25:
                    Console.WriteLine("This is a corner of the dungeon, walls to the south and east!");
                    break;
            }
            

        }

        public void AfterBattleNarration()
        {
            Console.WriteLine("You have slain the enemy! You look around you to get your bearings.");
        }

        public void itemNarration()
        {
            Console.WriteLine("You see a potion on the ground and can't help yourself, you drink it without reading the label!");
        }

    }

}
